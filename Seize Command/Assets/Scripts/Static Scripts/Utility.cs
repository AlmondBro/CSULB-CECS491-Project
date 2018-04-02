using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utility
{
    public static GameObject startingShip;

    public static GameObject FindParent(GameObject child)
    {
        GameObject parent;

        if (child.transform.parent)
        {
            parent = child.transform.parent.gameObject;
            return FindParent(parent);
        }

        return child;
    }
}