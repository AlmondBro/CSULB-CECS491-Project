using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldHealthManager : MonoBehaviour, IDamageable, IRepairable
{
    [SerializeField] protected float health;
    [SerializeField] float regenHealth;
    [SerializeField] float repairAmount;
    [SerializeField] float waitToRegenHealth;
    [SerializeField] float waitToRepairTime;

    IEnumerator coRegenShield;
    SpriteRenderer sprite;

    float maxHealth;
    float minHealth;
    float maxColor;
    float minColor;
    bool disabled;
    bool canRepair;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();

        maxHealth = health;
        minHealth = 0;
        canRepair = true;
    }

    public void TakeDamage(float damage)
    {
        if (!disabled)
        {
            ChangeHealth(-damage);
        }
    }

    public void Repair()
    {
        if (canRepair)
        {
            health += repairAmount;
            StartCoroutine(CoWaitToRepair());
        }
    }

    void ChangeHealth(float change)
    {
        health += change;
        //Mathf.Clamp(sprite.color.a, );
        Mathf.Clamp(health, minHealth, maxHealth);
        CheckHealth();
    }

    void CheckHealth()
    {
        if (health == minHealth)
        {
            disabled = true;
            StopCoroutine(coRegenShield);
        }
        if (health == maxHealth)
        {
            disabled = false;
            StartCoroutine(coRegenShield);
        }
    }

    IEnumerator CoWaitToRepair()
    {
        canRepair = false;
        yield return new WaitForSeconds(waitToRepairTime);
        canRepair = true;
    }

    IEnumerator CoRegenShield()
    {
        while (true)
        {
            health += regenHealth;
            yield return new WaitForSeconds(waitToRegenHealth);
        }
    }
}
