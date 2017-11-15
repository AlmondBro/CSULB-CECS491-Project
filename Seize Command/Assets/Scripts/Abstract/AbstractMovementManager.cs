﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractMovementManager : MonoBehaviour
{
    [SerializeField] float speed;

    protected abstract void Movement();
}
