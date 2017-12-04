using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingCamera : MonoBehaviour
{
    [Header("Top Level/Deck Level changes")]
    [SerializeField] float changeLayerViewLowPoint;
    [SerializeField] float changeLayerViewHighPoint;
    [SerializeField] float changeOpacityStrength;

    [Space]

    [Header("Zooming Boundaries")]
    [SerializeField] int startingSize;
    [SerializeField] int lowerBound;
    [SerializeField] int upperBound;

    float newSize;

    Camera main;

    void Start()
    {
        main = GetComponent<Camera>();
        main.orthographicSize = startingSize;
    }

    void FixedUpdate()
    {
        Scroll();
    }

    void Scroll()
    {
        float delta = Input.GetAxis("Mouse ScrollWheel");

        newSize = main.orthographicSize;

        if (delta > 0f)
        {
            newSize--;
            Check(delta);
        }
        if (delta < 0f)
        {
            newSize++;
            Check(delta);
        }

        if (newSize < upperBound && newSize > lowerBound)
        {
            main.orthographicSize = newSize;
        }
    }

    void ChangeAlpha(float delta)
    {
        GameObject player = GetComponent<CameraController>().Player;
        GameObject ship = player.transform.parent.parent.gameObject;

        if (ship.CompareTag("Ship"))
        {
            SpriteRenderer[] topLevelSprites = ship.GetComponentsInChildren<SpriteRenderer>();
            for (int i = 0; i < topLevelSprites.Length; i++)
            {
                if (topLevelSprites[i].sortingLayerName == "Ship Top Level")
                {
                    Color newColor = topLevelSprites[i].color;
                    newColor.a += -delta * changeOpacityStrength;

                    topLevelSprites[i].color = newColor;
                }
            }
        }
    }

    void Check(float delta)
    {
        if (newSize < changeLayerViewHighPoint && newSize > changeLayerViewLowPoint)
        {
            ChangeAlpha(delta);
        }
    }
}
