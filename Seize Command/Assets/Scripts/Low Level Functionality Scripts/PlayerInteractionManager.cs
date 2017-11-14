using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractionManager : MonoBehaviour
{
   void OnCollisionStay2D(Collision2D coll)
    {
        if(coll.gameObject.CompareTag("Interactable"))
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                IInteractable inter = coll.gameObject.GetComponent<IInteractable>();
                inter.Interact();
            }
        }
    }
}
