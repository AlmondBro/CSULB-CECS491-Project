using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seat : MonoBehaviour, IInteractable
{
    //IInteractable interface
    public void Interact()
    {
        //Do something
        Debug.Log("call interact");
    }
}
