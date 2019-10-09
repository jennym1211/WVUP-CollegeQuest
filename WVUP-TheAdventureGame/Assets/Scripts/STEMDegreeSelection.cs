using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class STEMDegreeSelection : MonoBehaviour
{
    public Dropdown STEMDropdown;
    public GameObject InfoText;
    public string FillerText = "This is filler text for now";
    string STEMText = "Whether you are interested in computers, electronics, manufacturing, or biological and chemical sciences, you will be able to expand your knowledge and talents with one of our STEM programs. \n \n \n Some lead directly to certifications and quick entry into the workforce, while others provide excellent preparation for transferring to a four-year college or attending graduate school. \n Select a degree above to learn more about it, and relevant contact information.";
    string ComputerScienceText = "The Associate of Applied Science in Computer Science gives students a foundation in computer programming and software development and provides academic as well as hands-on coursework in programming, web design, database design and SQL, systems administration and network theory.This program will provide students a clear transition to employment in the fields of software development and/or into the Bachelor of Applied Technology in Software Engineering.\n\n Advisor: Gary Thompson \n Email: gary.thompson@wvup.edu";
    string SEText = "The Bachelor of Applied Technology (BAT) in Software Engineering is designed for students who complete the Associate of Applied Science in Computer Science degree and want to learn advanced skills in software engineering. \n\n Advisor: Charles Almond \n Email: calmond@wvup.edu";
    // Update is called once per frame
    void Update()
    {
        switch(STEMDropdown.value)
        {

            case 0:
                InfoText.GetComponent<Text>().text = STEMText;
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
            //Computer Science
            case 5:
                InfoText.GetComponent<Text>().text = ComputerScienceText;
                break;
            case 6:
                InfoText.GetComponent<Text>().text = FillerText;
                break;
            case 7:
                InfoText.GetComponent<Text>().text = FillerText;
                break;
            case 8:
                InfoText.GetComponent<Text>().text = FillerText;
                break;
            case 9:
                InfoText.GetComponent<Text>().text = FillerText;
                break;
            case 10:
                InfoText.GetComponent<Text>().text = FillerText;
                break;
            case 11:
                InfoText.GetComponent<Text>().text = FillerText;
                break;

            //Software Engineering
            case 12:
                InfoText.GetComponent<Text>().text = SEText;
                break;
            case 13:
                InfoText.GetComponent<Text>().text = FillerText;
                break;
        }
    }
}
