using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : IHeapItem<Node>{

    public bool walkable;
    public Vector3 worldPosition;

    public int GridX;
    public int GridY;

    public int gCost, hCost;

    public Node parent;

    int heapIndex;

    public Node(bool _walkable, Vector3 _worldPosition, int x, int y)
    {
        walkable = _walkable;
        worldPosition = _worldPosition;
        GridX = x;
        GridY = y;
    }

    public int totalCost
    {
        get { return gCost + hCost; }
    }

    public int HeapIndex
    {
        get
        {
            return heapIndex;
        }
        set
        {
            heapIndex = value;
        }
    }

    public int CompareTo(Node n2)
    {
        int compare = totalCost.CompareTo(n2.totalCost);
        if(compare == 0)
        {
            compare = hCost.CompareTo(n2.hCost);
        }
        return -compare;
    }
}
