using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeHairColor : MonoBehaviour
{
    public GameObject HairPanel;
    public SpriteRenderer hair;
    public Image circleHairColor;
    public int whatHairColor = 1;
  

    public Color[] colors;

    public void Update()
    {

        circleHairColor.color = hair.color;
 
        for(int i =0; i < colors.Length; i++)
        {
            if(i == whatHairColor)
            {
                hair.color = colors[i];
            }
        }

    }

    public void ChangePanelState(bool state)
    {
        HairPanel.SetActive(state);
    }

    public void OpenHairPanel()
    {
        HairPanel.SetActive(true);
    }

    public void CloseHairPanel()
    {
        HairPanel.SetActive(false);
    }


    public void ChangeHairsColor(int index)
    {
        whatHairColor = index;
    }

}
