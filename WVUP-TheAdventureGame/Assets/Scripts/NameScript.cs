using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameScript : MonoBehaviour
{

    public GameObject inputField;
    private Player player;
    // Start is called before the first frame update

    public void StoreName()
    {
        player = FindObjectOfType<Player>();

        player.Name = inputField.GetComponent<Text>().text;


    }

   
  
}
