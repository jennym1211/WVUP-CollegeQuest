using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CheckboxScript : MonoBehaviour
{
    public Toggle FAFSAToggle;
    public Toggle OLSISToggle;
    public Toggle TranscriptToggle;
    public GameObject ContinueButton;
 


    // Start is called before the first frame update
    void Start()
    {
        ContinueButton.SetActive(false);
        Debug.Log("Continue button inactive.");
    }

    void Update()
    {
        if (FAFSAToggle.isOn == true && OLSISToggle.isOn == true && TranscriptToggle.isOn == true)
        {
            ContinueButton.SetActive(true);
            Debug.Log("Continue button active.");
        }
        else
            ContinueButton.SetActive(false);
             Debug.Log("Continue button inactive.");
    }

    // Update is called once per frame

    
}
