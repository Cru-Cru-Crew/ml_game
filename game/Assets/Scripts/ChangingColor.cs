using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangingColor : MonoBehaviour {

    public SpriteRenderer[] sprites;
    public Color red;
    public Color yellow;
    public Color green;
    public Color brown;

    public int whatColor = 1;

    private Color actualColor;

    void Update()
    {
        switch (whatColor)
        {
            case 1:
                actualColor = yellow;
                break;
            case 2:
                actualColor = red;
                break;
            case 3:
                actualColor = brown;
                break;
            case 4:
                actualColor = green;
                break;
        }
        foreach (SpriteRenderer renderer in sprites)
        {
            renderer.color = actualColor;
        }
    }

    public void ChangeHeadColor(int newColorIndex)
    {
        whatColor = newColorIndex;
    }
}
