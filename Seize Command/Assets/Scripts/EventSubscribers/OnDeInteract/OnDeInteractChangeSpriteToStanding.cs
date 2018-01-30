using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDeInteractChangeSpriteToStanding : AbstractSubscribers<AbstractSeat>
{
    [SerializeField] Sprite standingSprite;

    void OnEnable()
    {
        type.onDeInteract += ChangeSpriteToStanding;
    }

    void OnDisable()
    {
        if (type)
        {
            type.onDeInteract -= ChangeSpriteToStanding;
        }
    }

    void ChangeSpriteToStanding(GameObject interactor)
    {
        SpriteRenderer renderer = interactor.GetComponent<SpriteRenderer>();
        renderer.sprite = standingSprite;
    }
}
