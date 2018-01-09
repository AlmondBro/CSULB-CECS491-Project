using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utility
{
    public static GameObject FindParent(GameObject child)
    {
        GameObject parent = child.transform.parent.gameObject;

        if (child.transform.parent)
        {
            return FindParent(parent);
        }
        else
        {
            return parent;
        }
    }

    public static Collider2D[] FindAllColliders(GameObject parent)
    {
        Collider2D[] coll =  parent.GetComponentsInChildren<Collider2D>();
        return coll;
    }
}