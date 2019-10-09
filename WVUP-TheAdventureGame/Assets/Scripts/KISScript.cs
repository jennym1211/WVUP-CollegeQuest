using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KISScript : MonoBehaviour
{


    public GameObject KISPanel;
   
    
    // Start is called before the first frame update
    
     public void Start()
    {
        KISPanel.SetActive(false);
    }
        
    public void OpenKISPanel()
    {

        KISPanel.SetActive(true);
        
    }

    // Update is called once per frame
    public void CloseKISPanel()
    {
        KISPanel.SetActive(false);
        
    }
}
