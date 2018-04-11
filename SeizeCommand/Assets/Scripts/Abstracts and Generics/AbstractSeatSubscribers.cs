using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractSeatSubscribers : MonoBehaviour
{
    protected AbstractSeat seat;

    void Awake()
    {
        seat = GetComponentInParent<AbstractSeat>();
    }
}
