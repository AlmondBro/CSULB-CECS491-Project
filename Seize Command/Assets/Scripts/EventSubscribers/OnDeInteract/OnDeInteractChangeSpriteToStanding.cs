using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDeInteractChangeSpriteToStanding : AbstractSeatSubscriber
{
    [SerializeField] Sprite standingSprite;

    void OnEnable()
    {
        seat.onDeInteract += ChangeSpriteToStanding;
    }

    void OnDisable()
    {
        if (seat)
        {
            seat.onDeInteract -= ChangeSpriteToStanding;
        }
    }

    void ChangeSpriteToStanding(GameObject interactor)
    {
        SpriteRenderer renderer = interactor.GetComponent<SpriteRenderer>();
        renderer.sprite = standingSprite;
    }
}
