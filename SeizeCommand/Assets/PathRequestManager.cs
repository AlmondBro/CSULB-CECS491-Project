using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PathRequestManager : MonoBehaviour {

	Queue<PathRequest> pathRequestQueue = new Queue<PathRequest>();
	PathRequest current;

	static PathRequestManager instance;

	PathAlgorithm pa;

	bool isProcessingPath;

	struct PathRequest
	{
		public Vector3 pathStart;
		public Vector3 pathEnd;
		public Action<Vector3[], bool> callback;

		public PathRequest(Vector3 start, Vector3 end, Action<Vector3[], bool> cb)
		{
			pathStart = start;
			pathEnd = end;
			callback = cb;
		}
	}

	void Start()
	{
		instance = this;
		pa = GetComponent<PathAlgorithm>();
	}

	public static void RequestPath(Vector3 pathStart, Vector3 pathEnd, Action<Vector3[], bool> callback)
	{
		PathRequest newRequest = new PathRequest(pathStart, pathEnd, callback);
		instance.pathRequestQueue.Enqueue(newRequest);
		instance.TryProcessNext();
	}

	void TryProcessNext()
	{
		if (!isProcessingPath && pathRequestQueue.Count > 0)
		{
			current = pathRequestQueue.Dequeue();
			isProcessingPath = true;
			pa.StartFindPath(current.pathStart, current.pathEnd);
		}
	}

	public void FinishProcessingPath(Vector3[] path, bool success)
	{
		current.callback(path, success);
		isProcessingPath = false;
		TryProcessNext();
	}
}
