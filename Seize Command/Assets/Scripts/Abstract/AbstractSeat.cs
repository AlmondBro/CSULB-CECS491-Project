using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractSeat : MonoBehaviour, IInteractable
{
    public delegate void InteractableAction(GameObject interactor);
    public event InteractableAction onInteract;
    public event InteractableAction onDeInteract;

    protected bool isTaken;

    void Start()
    {
        isTaken = false;
    }

    public virtual void Interact(GameObject interactor)
    {
        isTaken = isTaken == true ? false : true;

        if(isTaken)
        {
            TakeASeat(interactor);
        }
        else
        {
            LeaveSeat(interactor);
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
