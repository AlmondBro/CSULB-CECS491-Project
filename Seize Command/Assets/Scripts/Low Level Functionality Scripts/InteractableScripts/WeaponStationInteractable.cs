using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class WeaponStationInteractable : MonoBehaviour, IInteractable
{
    enum State
    {
        attached,
        detached
    }

    [SerializeField] GameObject weapon;
    Transform weaponParent;
    State currentState;

    void Start()
    {
        weaponParent = weapon.transform.parent;
        currentState = State.attached;
    }

    public void Interact(GameObject interactor)
    {
        if (interactor.CompareTag("Character"))
        {
            if(currentState == State.detached)
            {
                if(interactor.GetComponentInChildren<PlayerInteractor>().Weapon)
                {
                    weapon = interactor.GetComponentInChildren<PlayerInteractor>().Weapon;
                    AttachWeapon(interactor);
                }
            }
            else if (currentState == State.attached)
            {
                if(interactor.GetComponentInChildren<PlayerInteractor>().Weapon == null)
                {
                    DetachWeapon(interactor);
                }
            }
        }
    }

    void DetachWeapon(GameObject interactor)
    {
        interactor.GetComponentInChildren<PlayerInteractor>().Weapon = weapon;
        interactor.GetComponentInChildren<WeaponCarryingSprite>().SetSprite();

        currentState = State.detached;
        weapon.SetActive(false);
    }

    void AttachWeapon(GameObject interactor)
    {
        interactor.GetComponentInChildren<PlayerInteractor>().Weapon = null;
        interactor.GetComponentInChildren<WeaponCarryingSprite>().DisableSprite();

        currentState = State.attached;
        weapon.SetActive(true);
    }
}
