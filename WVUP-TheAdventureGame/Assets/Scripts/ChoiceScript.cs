using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceScript : MonoBehaviour
{
    public GameObject TextBox;

    public GameObject ChoiceYes;
    public GameObject ChoiceNo;
    public int ChoiceMade;
    public GameObject AdmissionsButton;
    public GameObject CareerServicesButton;

    void Start()
    {
        AdmissionsButton.SetActive(false);
        CareerServicesButton.SetActive(false);

    }

    public void ChoiceOptionYes()
    {
        TextBox.GetComponent<Text>().text = "Alright, let's continue on to Student Services, and get started with admissions.";
        ChoiceMade = 1;
        AdmissionsButton.SetActive(true);
    }


    public void ChoiceOptionNo()
    {

        TextBox.GetComponent<Text>().text = "Alright, then instead, then let's take a stop to the career center!";
        ChoiceMade = 2;
        CareerServicesButton.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(ChoiceMade >=1)
        {
            ChoiceYes.SetActive(false);
            ChoiceNo.SetActive(false);

        }
        
    }
}
