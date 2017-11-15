using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponFireManager: AbstractWeaponFireManager
{
    public override void Fire()
    {
        if(proj)
        {
            Instantiate(proj, projSpawnPoint.position, projSpawnPoint.rotation);
        }
    }
}
