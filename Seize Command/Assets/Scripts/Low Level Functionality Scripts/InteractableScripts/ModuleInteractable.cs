using System;
using System.Collections.Generic;
using UnityEngine;

public class ModuleInteractable : MonoBehaviour, IInteractable
{
    [SerializeField] IRepairable repairSatation;

    public void Interact(GameObject interactor)
    {
        if(interactor.CompareTag("Character"))
        {
            repairSatation.Repair();
        }
    }
}
