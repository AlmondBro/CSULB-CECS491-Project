using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipWeaponControlManager : MonoBehaviour
{
    public delegate void ActivateWeapon(AbstractWeaponFireManager weapon);
    public event ActivateWeapon onActivate;

    AbstractAttackManager shipAttackManager;

    void Start()
    {
        shipAttackManager = GetComponent<AbstractAttackManager>();   
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            Cannon cannon = GetComponentInChildren<Cannon>();
            onActivate(cannon);
        }
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            shipAttackManager.Weapon = null;
            Cannon cannon = GetComponentInChildren<Cannon>();
            cannon.gameObject.GetComponent<AbstractAimManager>().enabled = false;
        }
        
        //All other weapons down here
    }
}
