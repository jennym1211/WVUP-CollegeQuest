using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KISScript : MonoBehaviour
{
    public Text levelText;
    public Text majorText;
    public Text nameText;
    public Text EXPText;
    private Player player;
   
    
   
    
    // Start is called before the first frame update
    
     public void Start()
    {
        player = FindObjectOfType<Player>();
        nameText.text = player.Name;
        levelText.text = player.Level;
        majorText.text = player.Major;
        EXPText.text = player.EXPAwarded.ToString();

        player.transform.localScale = new Vector2(1.5f, 1.5f);
        player.transform.position = new Vector2(-.35f, 3.3f);
       
    }


 
}
