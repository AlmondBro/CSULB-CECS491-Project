using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngineHealthManager : MonoBehaviour, IDamageable, IRepairable
{
    [SerializeField] protected float health;
    [SerializeField] float repairAmount;
    [SerializeField] float waitToRepairTime;

    float maxHealth;
    float minHealth;
    bool disabled;
    bool canRepair;

    void Start()
    {
        maxHealth = health;
        minHealth = 0;

        canRepair = true;
    }

    public void TakeDamage(float damage)
    {
        ApplyDamage(damage);
    }

    public void Repair()
    {
        if(canRepair)
        {
            health += repairAmount;
            StartCoroutine(CoWaitToRepair());
        }
    }

    protected virtual void ApplyDamage(float damage)
    {
        health -= damage;
        Mathf.Clamp(health, minHealth, maxHealth);

        CheckHealth();
    }

    void CheckHealth()
    {
        if (health == minHealth)
        {
            disabled = true;
        }
        if(health == maxHealth)
        {
            disabled = false;
        }
    }

    IEnumerator CoWaitToRepair()
    {
        canRepair = false;
        yield return new WaitForSeconds(waitToRepairTime);
        canRepair = true;
    }
}
