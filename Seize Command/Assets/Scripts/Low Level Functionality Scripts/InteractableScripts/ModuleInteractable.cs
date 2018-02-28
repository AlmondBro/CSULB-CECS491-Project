using System;
using System.Collections.Generic;
using UnityEngine;

public class ModuleInteractable : MonoBehaviour, IInteractable
{
    IRepairable repairSatation;

    void Start()
    {
        repairSatation = GetComponentInChildren<IRepairable>();
    }

    public void Interact(GameObject interactor)
    {
        if(interactor.CompareTag("Character"))
        {
            repairSatation.Repair();
        }
    }
}
