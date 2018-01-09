using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingCamera : MonoBehaviour
{
    [SerializeField] int lowerBound;
    [SerializeField] int upperBound;

    [SerializeField] int fadeValue;

    float orthoSize;

    Camera mainCamera;

    bool fadedOut;
    bool fadedIn;

    void Start()
    {
        mainCamera = GetComponent<Camera>();

        orthoSize = 30;

        fadedOut = false;
        fadedIn = false;


        //Fade();
    }

    void FixedUpdate()
    {
        Scroll();
    }

    void Scroll()
    {
        float delta = Input.GetAxis("Mouse ScrollWheel");

        if (delta > 0f)
        {
            orthoSize--;
        }
        if (delta < 0f)
        {
            orthoSize++;
        }

        orthoSize = Mathf.Clamp(orthoSize, lowerBound, upperBound);
        mainCamera.orthographicSize = orthoSize;
    }

    void Fade()
    {
        GameObject ship =  Utility.FindParent(PlayerReference.p);
        Debug.Log(ship);
        SpriteRenderer[] sprites = ship.GetComponentsInChildren<SpriteRenderer>();

        for(int i = 0; i < sprites.Length; i++)
        {
            if(sprites[i].sortingLayerName == "Ship Top Level")
            {
                Color a = sprites[i].color;

                Color b = a;
                b.a = 0f;

                sprites[i].color = Color.Lerp(a, b, 1);
            }
        }
    }
}
