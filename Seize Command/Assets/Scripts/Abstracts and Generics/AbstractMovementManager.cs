using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public abstract class AbstractMovementManager : MonoBehaviour
{
    [SerializeField] protected float strength;

    protected abstract void Movement();
}
