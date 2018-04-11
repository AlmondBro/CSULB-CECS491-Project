using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnInteractChangeSpriteToSeated : AbstractSubscribers<AbstractSeat>
{
    [SerializeField] Sprite seatedSprite;

    void OnEnable()
    {
        type.onInteract += ChangePlayerSpriteToSeated;
    }

    void OnDisable()
    {
        if(type)
        {
            type.onInteract -= ChangePlayerSpriteToSeated;
        }
    }

    void ChangePlayerSpriteToSeated(GameObject interactor)
    {
        SpriteRenderer renderer = interactor.GetComponent<SpriteRenderer>();
        renderer.sprite = seatedSprite;
    }
}
