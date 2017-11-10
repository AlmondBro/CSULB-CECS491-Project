using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponFireManager: AbstractWeaponFireManager
{
    public override void Fire()
    {
        Instantiate(proj, projSpawnPoint.position, projSpawnPoint.rotation);
    }
}
