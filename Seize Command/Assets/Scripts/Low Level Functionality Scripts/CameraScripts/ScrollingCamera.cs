using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class ScrollingCamera : NetworkBehaviour
{
    [Header("Scroll Boundaries")]
    [SerializeField] int lowerBound;
    [SerializeField] int upperBound;

    [Space]

    [Header("Ship Fade Values")]
    [SerializeField] float fadeSpeed;
    [SerializeField] int fadeInValue;
    [SerializeField] int fadeOutValue;

    float orthoSize;

    Camera mainCamera;

    IEnumerator coFadeIn;
    IEnumerator coFadeOut;

    bool fadedIn;

    void Start()
    {
        mainCamera = GetComponent<Camera>();
        orthoSize = 30;
        fadedIn = false;

        GameObject ship = Utility.FindParent(PlayerReference.p);

        SpriteRenderer[] sprites = ship.GetComponentsInChildren<SpriteRenderer>();

        coFadeIn = CoFadeIn(sprites);
        coFadeOut = CoFadeOut(sprites);
    }

    void FixedUpdate()
    {
        Scroll();
        CheckToFade();
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

    void CheckToFade()
    {
        if(mainCamera.orthographicSize <= fadeInValue && !fadedIn)
        {
            FadeIn();
        }
        else if(mainCamera.orthographicSize >= fadeOutValue && fadedIn)
        {
            FadeOut();
        }
    }

    void FadeIn()
    {
        if (PlayerReference.p)
        {
            fadedIn = true;

            GameObject ship = Utility.FindParent(PlayerReference.p);
            SpriteRenderer[] sprites = ship.GetComponentsInChildren<SpriteRenderer>();

            StopCoroutine(coFadeOut);
            coFadeIn = CoFadeIn(sprites);
            StartCoroutine(coFadeIn);
        }
    }

    IEnumerator CoFadeIn(SpriteRenderer[] sprites)
    {
        float t = 0f;
        while (sprites[0].color.a != 0f)
        {
            for (int i = 0; i < sprites.Length; i++)
            {
                if (sprites[i].sortingLayerName == "Ship Top Level")
                {
                    Color a = sprites[i].color;
                    t += Time.deltaTime * fadeSpeed;
                    float alpha = Mathf.Lerp(a.a, 0f, t);
                    a.a = alpha;
                    sprites[i].color = a;
                }
            }

            yield return null;
        }
    }

    void FadeOut()
    {
        if(PlayerReference.p)
        {
            fadedIn = false;

            GameObject ship = Utility.FindParent(PlayerReference.p);
            SpriteRenderer[] sprites = ship.GetComponentsInChildren<SpriteRenderer>();

            StopCoroutine(coFadeIn);
            coFadeOut = CoFadeOut(sprites);
            StartCoroutine(coFadeOut);
        }
    }

    IEnumerator CoFadeOut(SpriteRenderer[] sprites)
    {
        float t = 0f;
        while (sprites[0].color.a != 1f)
        {
            for (int i = 0; i < sprites.Length; i++)
            {
                if (sprites[i].sortingLayerName == "Ship Top Level")
                {
                    Color a = sprites[i].color;
                    t += Time.deltaTime * fadeSpeed;
                    float alpha = Mathf.Lerp(a.a, 1f, t);
                    a.a = alpha;
                    sprites[i].color = a;
                }
            }

            yield return null;
        }
    }
}
