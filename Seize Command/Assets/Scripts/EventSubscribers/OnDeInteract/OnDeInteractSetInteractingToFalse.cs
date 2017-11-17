﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDeInteractSetInteractingToFalse : AbstractSeatSubscriber
{
    void OnEnable()
    {
        seat.onDeInteract += SetInteractingToFalse;
    }

    void OnDisable()
    {
        if (seat)
        {
            seat.onDeInteract -= SetInteractingToFalse;
        }
    }

    void SetInteractingToFalse(GameObject interactor)
    {
        AbstractInteractionManager manager = interactor.GetComponent<AbstractInteractionManager>();
        manager.IsInteracting = false;
    }
}
