using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractSubscribers<T> : MonoBehaviour
{
    protected T type;

    void Awake()
    {
        type = GetComponentInParent<T>();
    }
}
