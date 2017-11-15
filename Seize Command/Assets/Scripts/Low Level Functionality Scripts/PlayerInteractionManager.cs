using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractionManager : MonoBehaviour
{
   void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("Interactable"))
        {
            //can't use input outside of update()
            //if (Input.GetKeyDown(KeyCode.E))
            //{
                IInteractable inter = coll.gameObject.GetComponent<IInteractable>();
                inter.Interact();
            //}
        }
    }
}
