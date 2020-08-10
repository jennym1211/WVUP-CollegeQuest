using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangingColor : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject panel;
    


    public SpriteRenderer skinSkinny;
    public Image circleSkinColor;
    

    

    public int whatColor = 1;

    public Color[] colors;

    public void Update()
    {

        circleSkinColor.color = skinSkinny.color;

        for (int i = 0; i < colors.Length; i++)
        {
            if (i == whatColor)
            {
                skinSkinny.color = colors[i];
            }
        }

    }

    public void ChangePanelState(bool state)
    {
       panel.SetActive(state);
    }



    public void ChangeColor(int index)
    {
        whatColor = index;
    }






}
