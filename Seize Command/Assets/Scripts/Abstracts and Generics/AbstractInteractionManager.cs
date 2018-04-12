using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractInteractionManager : MonoBehaviour
{
    protected IInteractable interactable;

    GameObject interactableObject;

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.GetComponentInParent<IInteractable>() != null)
        {
            interactableObject = coll.gameObject;
            interactable = coll.gameObject.GetComponentInParent<IInteractable>();
        }
    }

    void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.gameObject.Equals(interactableObject))
        {
            interactable = null;
        }
    }
}
