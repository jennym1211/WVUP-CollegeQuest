using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeAppearance : MonoBehaviour
{
    // Start is called before the first frame update
    //public GameObject panel;
    public SpriteRenderer part;
    public Sprite[] options;
   
    public int index;
    void Update()
    {
        for(int i = 0; i < options.Length; i++)
        {
            if(i == index)
            {
                part.sprite = options[i];
            }
        }
    }

    public void Swap()
    {
        if(index < options.Length -1)
        {
            index++;
        }
        else
        {
            index = 0;
        }
    }


   
 
}
