using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnInteractChangeSpriteToSeated : AbstractSeatSubscribers
{
    [SerializeField] Sprite seatedSprite;

    void OnEnable()
    {
        seat.onInteract += ChangePlayerSpriteToSeated;
    }

    void OnDisable()
    {
        if(seat)
        {
            seat.onInteract -= ChangePlayerSpriteToSeated;
        }
    }

    void ChangePlayerSpriteToSeated(GameObject interactor)
    {
        SpriteRenderer renderer = interactor.GetComponent<SpriteRenderer>();
        renderer.sprite = seatedSprite;
    }
}
