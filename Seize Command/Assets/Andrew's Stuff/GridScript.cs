using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour {

    public Transform AI;
    public Transform target;
    public LayerMask unwalkableMask;
    public Vector2 gridWorldSize;
    public float nodeRadius;
    Node[,] grid;
    public bool displayGridGizmos;

    float nodeDiameter;
    int gridSizex, gridSizey;

    void Awake()
    {
        nodeDiameter = nodeRadius * 2;
        gridSizex = Mathf.RoundToInt(gridWorldSize.x / nodeDiameter);
        gridSizey = Mathf.RoundToInt(gridWorldSize.y / nodeDiameter);

        CreateGrid();
    }

    public int MaxSize
    {
        get
        {
            return gridSizex * gridSizey;
        }
    }

    void CreateGrid()
    {
        grid = new Node[gridSizex, gridSizey];
        Vector3 worldBottomLeft = transform.position - Vector3.right * gridWorldSize.x / 2 - Vector3.up * gridWorldSize.y / 2;

        for(int i = 0; i < gridSizex; i++)
        {
            for(int j = 0; j < gridSizey; j++)
            {
                Vector3 worldPoint = worldBottomLeft + Vector3.right * (i * nodeDiameter + nodeRadius) + Vector3.up * (j * nodeDiameter + nodeRadius);
                bool walkable = !(Physics2D.OverlapCircle(worldPoint, nodeRadius, unwalkableMask));
                
                grid[i, j] = new Node(walkable, worldPoint, i, j);
            }
        }  
    }

    public List<Node> GetNeighborNodes(Node node)
    {
        List<Node> neighbors = new List<Node>();

        for(int i = -1; i <= 1; i++)
        {
            for(int j = -1; j <= 1; j++)
            {
                if(i == 0 && j == 0)
                {
                    continue;
                }

                int checkX = node.GridX + i;
                int checkY = node.GridY + j;

                if(checkX >= 0 && checkX < gridWorldSize.x && checkY >= 0 && checkY < gridWorldSize.y)
                {
                    neighbors.Add(grid[checkX, checkY]);
                }
            }
        }

        return neighbors;
    }

    public Node NodeFromWorldPoint(Vector3 WorldPosition)
    {
        float percentX = (WorldPosition.x + gridWorldSize.x / 2) / gridWorldSize.x;
        float percentY = (WorldPosition.y + gridWorldSize.y / 2) / gridWorldSize.y;
        percentX = Mathf.Clamp01(percentX);
        percentY = Mathf.Clamp01(percentY);

        int x = Mathf.RoundToInt((gridSizex - 1) * percentX);
        int y = Mathf.RoundToInt((gridSizey - 1) * percentY);

        return grid[x, y];
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(transform.position, new Vector3(gridWorldSize.x, gridWorldSize.y, 1));

            if (grid != null && displayGridGizmos)
            {
                Node AINode = NodeFromWorldPoint(AI.position);
                Node TargetNode = NodeFromWorldPoint(target.position);
                foreach (Node n in grid)
                {
                    Gizmos.color = (n.walkable) ? Color.white : Color.red;

                    /*
                    if (AINode == n)
                    {
                        Gizmos.color = Color.cyan;
                    }
                    if(TargetNode == n)
                    {
                        Gizmos.color = Color.yellow;
                    }
                    */
                    Gizmos.DrawCube(n.worldPosition, new Vector3(1,1,0) * (nodeDiameter - .1f));
                }
            }
        }
    }
