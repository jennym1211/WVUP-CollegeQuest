using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class STEMDegreeSelection : MonoBehaviour
{
    public Dropdown STEMDropdown;
    public GameObject InfoText;
    public GameObject AdvisorEmailText;
    public string FillerText = "This is filler text for now";
    string STEMText = "Whether you are interested in computers, electronics, manufacturing, or biological and chemical sciences, you will be able to expand your knowledge and talents with one of our STEM programs. \n \n \n Some lead directly to certifications and quick entry into the workforce, while others provide excellent preparation for transferring to a four-year college or attending graduate school. \n Select a degree above to learn more about it, and relevant contact information.";
    // Update is called once per frame
    void Update()
    {
        switch (STEMDropdown.value)
        {

            case 0:
                InfoText.GetComponent<Text>().text = STEMText;
                break;
        }
    }

}
