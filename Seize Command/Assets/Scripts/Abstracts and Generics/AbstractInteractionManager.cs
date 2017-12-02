using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractInteractionManager : MonoBehaviour
{
    protected IInteractable interactable;

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("Interactable"))
        {
            interactable = coll.gameObject.GetComponentInParent<IInteractable>();
        }
    }

    void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("Interactable"))
        {
            interactable = null;
        }
    }
}
