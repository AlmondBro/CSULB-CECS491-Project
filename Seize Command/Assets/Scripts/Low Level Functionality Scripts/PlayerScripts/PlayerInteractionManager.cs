using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractionManager : MonoBehaviour
{
    IInteractable interactable;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            if(interactable != null)
            {
                interactable.Interact(gameObject);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.CompareTag("Interactable"))
        {
            interactable = coll.gameObject.GetComponentInParent<IInteractable>();
        }
    }
    
    void OnTriggerExit2D(Collider2D coll)
    {
        if(coll.gameObject.CompareTag("Interactable"))
        {
            interactable = null;
        }
    }   
}
