using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractor : AbstractInteractionManager
{
    public GameObject Weapon;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            if(interactable != null)
            {
                GameObject player = transform.parent.gameObject;
                interactable.Interact(player);
            }
        }
    }
}
