using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public abstract class AbstractAimManager : NetworkBehaviour
{
    protected abstract void Aim();
}
