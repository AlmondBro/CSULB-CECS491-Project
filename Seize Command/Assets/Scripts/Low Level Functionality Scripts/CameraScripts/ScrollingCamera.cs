using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingCamera : MonoBehaviour
{
    [SerializeField] int lowerBound;
    [SerializeField] int upperBound;

    Camera mainCamera;

    bool fadedOut;
    bool fadedIn;

    void Start()
    {
        mainCamera = GetComponent<Camera>();

        fadedOut = false;
        fadedIn = false;  
    }

    void FixedUpdate()
    {
        Scroll();
    }

    void Scroll()
    {
        float delta = Input.GetAxis("Mouse ScrollWheel");

        if (delta > 0f && !fadedIn)
        {
            
        }
        if (delta < 0f && !)
        {
            newSize++;
            Check(delta);
        }

        if (newSize < upperBound && newSize > lowerBound)
        {
            main.orthographicSize = newSize;
        }
    }

    IEnumerator FadeOut(bool fadedOut)
    {
        for(int i = )
    }
}
