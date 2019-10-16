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
    string AMTText = "WVU Parkersburg’s Advanced Manufacturing  Technology program prepares graduates for careers in the manufacturing sector. Advanced manufacturing technology graduates repair, troubleshoot and maintain a variety of manufacturing equipment including commercial, electrical and mechanical systems. Hands-on courses give our graduates practical experience in automation, instrumentation and process control systems, as well as basic machining skills in order to facilitate working with modern equipment. \n\n Advisor: Gerald Rowley";
    string ASText = "The Associate of Science degree program is designed for transfer to other colleges and universities for students seeking bachelor’s degrees. Students who wish to earn a Bachelor of Arts or Bachelor of Science degree at any other institution can complete their first two years at WVU Parkersburg. The Associate of Science program can lead to study in dentistry, medicine, pharmacy, physical therapy, veterinary science and much more. \n\n Advisor: Jared Gump";
    string CPOText = "The Chemical and Polymer Operator Technology program is a 32-hour Certificate of Applied Science. The hands-on program prepares individuals to enter the process operator/technician field. On-the-job training for students is arranged with employers in the chemical and polymer industry – students will complete alternating semesters of classroom work and training \n\n Advisor: William Channell";
    string CITText = "By  pursuing a degree in the Computer Information Technology program, you will work with cutting edge technology and solve interesting problems as you develop the skills necessary for success in networking, computer technology, systems administration and other related fields. Our program’s two-year and four-year degrees are designed with the input of industry leaders, and when students graduate from our program, they possess a degree, certification and experience – the top three things employers are looking for. Not to mention, students in the computer information technology program can seamlessly transfer into the cybersecurity and network administration program to receive their bachelor’s degree. \n\n Advisor: Doug Rhodes ";
    // Update is called once per frame
    void Update()
    {
        switch(STEMDropdown.value)
        {

            case 0:
                InfoText.GetComponent<Text>().text = STEMText;
                break;
            case 1:
                InfoText.GetComponent<Text>().text = AMTText;
                break;
            case 2:
                InfoText.GetComponent<Text>().text = ASText;
                break;
            case 3:
                InfoText.GetComponent<Text>().text = CPOText;
                break;
            case 4:
                InfoText.GetComponent<Text>().text = CITText;
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
