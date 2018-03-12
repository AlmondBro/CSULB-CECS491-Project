using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerReference : MonoBehaviour
{
    public static GameObject p;

    void Awake()
    {
        p = gameObject;
    }
}
