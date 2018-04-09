using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractor : AbstractInteractionManager
{
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
}
