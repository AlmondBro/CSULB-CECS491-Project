using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractSeat : MonoBehaviour, IInteractable
{
    public delegate void InteractableAction(GameObject interactor);
    public event InteractableAction onInteract;
    public event InteractableAction onDeInteract;

    //[SerializeField] protected ShipInteractor shipInteractor;

    public GameObject CurrentInteractor { get; set; }

    public virtual void Interact(GameObject interactor)
    {
        if(interactor.CompareTag("Character"))
        {
            if (CurrentInteractor != null)
            {
                if (interactor.Equals(CurrentInteractor))
                {
                    LeaveSeat(interactor);
                }
            }
            else
            {
                TakeASeat(interactor);
            }
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
