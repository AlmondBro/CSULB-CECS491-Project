using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipWeaponControlManager : MonoBehaviour
{
    public delegate void ActivateWeapon(AbstractWeaponManager weapon);
    public event ActivateWeapon onActivate;
    public event ActivateWeapon onDeactivate;

    AbstractWeaponManager currentWeapon;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            if(currentWeapon)
            {
                onDeactivate(currentWeapon);
            }

            currentWeapon = GetComponentInChildren<Cannon>();
            onActivate(currentWeapon);
        }
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            if(currentWeapon)
            {
                onDeactivate(currentWeapon);
            }

            currentWeapon = null;
            GetComponent<AbstractAttackManager>().Weapon = null;
        }
        
        //All other weapons down here
    }
}
