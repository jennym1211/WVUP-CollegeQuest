using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NursingDegreeSelection : MonoBehaviour
{
    public Dropdown NursingDropdown;
    public GameObject InfoText;
    public string FillerText = "This is filler text for now";
    string NurseText = "Offering a variety of courses, certifications and degrees in the healthcare field, our Nursing and Health Science programs will educate you on the communities we serve to become competent healthcare professionals. Through the use of cutting-edge technology, health and wellness activities and hands-on practice, you will be a desirable employee candidate upon graduation. \n Select a degree above to learn more about it, and relevant contact information.";
    
    // Update is called once per frame
    void Update()
    {
        switch(NursingDropdown.value)
        {

            case 0:
                InfoText.GetComponent<Text>().text = NurseText;
                break;
            case 1:
                InfoText.GetComponent<Text>().text = FillerText;
                break;
            case 2:
                InfoText.GetComponent<Text>().text = FillerText;
                break;
            case 3:
                InfoText.GetComponent<Text>().text = FillerText;
                break;
            case 4:
                InfoText.GetComponent<Text>().text = FillerText;
                break;
          
            case 5:
                InfoText.GetComponent<Text>().text = FillerText;
                break;
        
        }
    }
}
