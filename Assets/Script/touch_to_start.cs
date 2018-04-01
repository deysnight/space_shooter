using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch_to_start : MonoBehaviour {

    SpriteRenderer myRenderer;

    bool fadeIn = false;
    float myAlpha = 1f;
    Color tempColor;

    void Awake()
    {
        myRenderer = GetComponent<SpriteRenderer>();
        myAlpha = myRenderer.color.a;
    }

    void Update()
    {
        if (fadeIn)
        {
            myAlpha += 0.005f;
            if (myAlpha >= 1f)
                fadeIn = !fadeIn;
        }
        else
        {
            myAlpha -= 0.005f;
            if (myAlpha <= 0f)
                fadeIn = !fadeIn;
        }

        tempColor = myRenderer.color;
        tempColor.a = myAlpha;
        myRenderer.color = tempColor;
    }
}
