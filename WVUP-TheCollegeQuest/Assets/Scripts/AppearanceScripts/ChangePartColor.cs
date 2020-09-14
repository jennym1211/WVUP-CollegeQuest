using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChangePartColor : MonoBehaviour
{
    public GameObject partPanel;
    public SpriteRenderer part;
    public Image circleColor;
    public int whatColor = 1;


    public Color[] colors;

    public void Update()
    {

        circleColor.color = part.color;

        for (int i = 0; i < colors.Length; i++)
        {
            if (i == whatColor)
            {
                Debug.Log("Index of color array is" + i);
                part.color = colors[i];
            }
        }

    }

    public void ChangePanelState(bool state)
    {
        partPanel.SetActive(state);
    }

    public void OpenPartPanel()
    {
        partPanel.SetActive(true);
        Debug.Log("Part panel is open.");
    }

    public void ClosePartPanel()
    {

        Debug.Log("Part panel is closed.");
        partPanel.SetActive(false);
    }


    public void ChangePartsColor(int index)
    {
        whatColor = index;
    }

}
