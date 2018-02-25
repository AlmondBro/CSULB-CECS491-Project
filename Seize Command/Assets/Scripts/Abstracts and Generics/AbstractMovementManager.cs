using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

[RequireComponent(typeof(Rigidbody2D))]
public abstract class AbstractMovementManager : NetworkBehaviour
{
    [SerializeField] protected float strength;

    protected abstract void Movement();
}
