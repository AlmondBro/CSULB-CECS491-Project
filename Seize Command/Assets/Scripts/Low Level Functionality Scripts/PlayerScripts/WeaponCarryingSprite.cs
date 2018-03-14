using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class WeaponCarryingSprite : MonoBehaviour
{
    SpriteRenderer renderer;

    private void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
        renderer.enabled = false;
    }

    public void SetSprite()
    {
        renderer.enabled = true;
    }

    public void DisableSprite()
    {
        renderer.enabled = false;
    }
}
