using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BAPSScript : MonoBehaviour
{
    public Dropdown BAPSDropdown;
    public GameObject InfoText;
    public GameObject AdvisorEmailText;
    public string FillerText = "This is filler text for now";
    string BAPSText = "The Business, Accounting and Public Service division offers a variety of fully-accredited certificate, associate and bachelor’s degree programs as well as professional credentialing opportunities. \n\n From accounting to management and legal studies to criminal justice, the broad range of career programs will provide you with the job skills you need to secure employment and – for the working professional – opportunities to enhance existing business skills. \n Select a degree above to learn more about it, and relevant contact information.";
    
    // Update is called once per frame
    void Update()
    {
        switch(BAPSDropdown.value)
        {

            case 0:
                InfoText.GetComponent<Text>().text = BAPSText;
                break;
  
         
        }
    }

}
