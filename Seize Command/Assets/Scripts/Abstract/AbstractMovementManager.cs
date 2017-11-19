using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractMovementManager : MonoBehaviour
{
    [SerializeField] protected float strength;

    protected abstract void Movement();
}
