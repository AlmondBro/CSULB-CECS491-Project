using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Sets the Weapon and Implements the Attack
/// </summary>
public class AI_Ship_Attack : AbstractAttackManager
{
    // The Current Weapon
    [SerializeField] AbstractWeapon currentWeapon;
    [SerializeField] float warmUp;

    public GameObject WeaponLocation { get; private set; }

    Coroutine att;
    bool finishedWarmingUp;

    // Initialization
    void Start()
    {
        Weapon = currentWeapon;
        WeaponLocation = currentWeapon.gameObject;
    }

    /// <summary>
    /// Start Attacking When the Warm Up is Finished
    /// </summary>
    void Update()
    {
        if (finishedWarmingUp) Attack();
    }

    // Wait Until WarmUp is Finsished Then Proceed to Attack
    IEnumerator CoAttack()
    {
        yield return new WaitForSeconds(warmUp);
        finishedWarmingUp = true;
    }

    // Start Coroutine when we enter this Attack State
    void OnEnable()
    {
        att = StartCoroutine(CoAttack());
    }

    // Stop The Coroutine when we leave this Attack State
    void OnDisable()
    {
        StopCoroutine(att);    
    }
}
