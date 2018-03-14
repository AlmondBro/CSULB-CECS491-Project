using System;
using System.Collections.Generic;
using UnityEngine;

public class ModuleInteractable : MonoBehaviour, IInteractable
{
    [SerializeField] IRepairable repairStation;

    public void Interact(GameObject interactor)
    {
        if(interactor.CompareTag("Character"))
        {
            repairStation.Repair();
        }
    }
}
