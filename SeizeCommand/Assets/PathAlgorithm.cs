using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PathAlgorithm : MonoBehaviour {

	PathRequestManager requestManager;
	Grid grid;

	private void Awake()
	{
		requestManager = GetComponent<PathRequestManager>();
		grid = GetComponent<Grid>();
	}

	public void StartFindPath(Vector3 start, Vector3 end)
	{
		StartCoroutine(FindPath(start, end));
	}

	IEnumerator FindPath(Vector3 start, Vector3 destination)
	{
		Vector3[] wayPoints = new Vector3[0];
		bool pathSuccess = false;

		Node startNode = grid.NodeFromWorldPoint(start);
		Node endNode = grid.NodeFromWorldPoint(destination);

		if(startNode.walkable && endNode.walkable) {
			Heap<Node> openSet = new Heap<Node>(grid.MaxSize);
			HashSet<Node> closedSet = new HashSet<Node>();

			openSet.Add(startNode);

			while (openSet.Count > 0)
			{
				Node current = openSet.RemoveFirst();
				closedSet.Add(current);

				if (current == endNode)
				{
					pathSuccess = true;
					break;
				}

				foreach (Node neighbors in grid.GetNeighborNodes(current))
				{
					if (!neighbors.walkable || closedSet.Contains(neighbors))
					{
						continue;
					}

					int newMovementCostToNeighbor = current.gCost + GetDistance(current, neighbors);
					if (newMovementCostToNeighbor < neighbors.gCost || !(openSet.Contains(neighbors)))
					{
						neighbors.gCost = newMovementCostToNeighbor;
						neighbors.hCost = GetDistance(neighbors, endNode);

						neighbors.parent = current;

						if (!openSet.Contains(neighbors))
						{
							openSet.Add(neighbors);
						}
						else
						{
							openSet.UpdateItem(neighbors);
						}
					}
				}
			}
		}
		yield return null;
		if (pathSuccess)
		{
			wayPoints = RetracePath(startNode, endNode);
		}
		requestManager.FinishProcessingPath(wayPoints, pathSuccess);
	}

	Vector3[] RetracePath(Node start, Node end)
	{
		List<Node> path = new List<Node>();
		Node current = end;

		while(current != start)
		{
			path.Add(current);
			current = current.parent;
		}
		Vector3[] wayPoints = SimplifyPath(path);
		Array.Reverse(wayPoints);
		return wayPoints;
	}

	Vector3[] SimplifyPath(List<Node> path)
	{
		List<Vector3> wayPoints = new List<Vector3>();
		Vector2 directionOld = Vector2.zero;

		for(int i = 1; i < path.Count; i++)
		{
			Vector2 directionNew = new Vector2(path[i - 1].GridX - path[i].GridX, path[i-1].GridY - path[i].GridY);
			if(directionNew != directionOld)
			{
				wayPoints.Add(path[i].worldPosition);
			}
			directionOld = directionNew;
		}
		return wayPoints.ToArray();
	}

	int GetDistance(Node A, Node B)
	{
		int disX = Mathf.Abs(B.GridX - A.GridX);
		int disY = Mathf.Abs(B.GridY - A.GridY);

		if(disX > disY)
		{
			return 14 * disY + 10 * (disX - disY);
		}
		else
		{
			return 14 * disX + 10 * (disY - disX);
		}
	}
}
