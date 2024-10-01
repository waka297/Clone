using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomColor : MonoBehaviour
{
    public Image colorbox;
    public Button[] buttons;
    private Color targetColor;

    public void ColorUpdate() //image's color update
    {
        //Object Random colors
        targetColor = new Color(
            Random.Range(0f, 1f),  
            Random.Range(0f, 1f), 
            Random.Range(0f, 1f),
            1f
        );

        colorbox.color = targetColor;
        int correctButtonIndex = Random.Range(0, 3); //one of button's color = image's color

        for (int i = 0; i < buttons.Length; i++)
        {
            if (i == correctButtonIndex)
            {
                buttons[i].GetComponent<Image>().color = targetColor;
            }
            else
            {
                buttons[i].GetComponent<Image>().color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f),1f);
            }
        }
    }

    public Color GetColor()
    {
        return targetColor; //image color get
    }

    private void Start()
    {
        ColorUpdate();
    }
}
