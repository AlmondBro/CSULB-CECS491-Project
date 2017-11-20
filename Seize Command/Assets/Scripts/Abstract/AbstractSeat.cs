using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractSeat : MonoBehaviour, IInteractable
{
    public delegate void InteractableAction(GameObject interactor);
    public event InteractableAction onInteract;
    public event InteractableAction onDeInteract;

    public GameObject CurrentInteractor
    {
        set
        {
            currentInteractor = value;
        }
    }

    GameObject currentInteractor;

    public virtual void Interact(GameObject interactor)
    {
        if (currentInteractor)
        {
            if(interactor.Equals(currentInteractor))
            {
                LeaveSeat(interactor);
            }
        }
        else
        {
            TakeASeat(interactor);
        }
    }

    protected virtual void TakeASeat(GameObject interactor)
    {
        onInteract(interactor);
    }

    protected virtual void LeaveSeat(GameObject interactor)
    {
        onDeInteract(interactor);
    }
}
