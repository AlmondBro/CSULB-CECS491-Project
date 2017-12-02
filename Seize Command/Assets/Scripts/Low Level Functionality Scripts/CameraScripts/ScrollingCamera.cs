using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingCamera : MonoBehaviour
{
    [SerializeField] int switchLayerPoint;
    [SerializeField] int lowerBound;
    [SerializeField] int upperBound;

    float newSize;

    Camera main;

    void Start()
    {
        main = GetComponent<Camera>(); 
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
        }
        if (delta < 0f)
        {
            newSize++;
        }

        if (newSize < upperBound && newSize > lowerBound)
        {
            main.orthographicSize = newSize;
        }
    }

    void SwitchLayers()
    {
        SortingLayer[] layer = SortingLayer.layers;
        Canvas ASD;
    }
}
