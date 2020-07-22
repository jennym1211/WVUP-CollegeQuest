using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HFASSScript : MonoBehaviour
{
    public Dropdown HFASSDropdown;
    public GameObject InfoText;
    public GameObject AdvisorEmailText;
    public string FillerText = "This is filler text for now";
    string HFASSText = "The Humanities, Fine Arts, and Social Sciences division will prepare you for a wide variety of careers by providing the knowledge and skills of critical thinking, communication, and expression. \n You will receive rigorous professional training to explore employment opportunities in academia, the arts, public and cultural institutions, and related fields. \n Select a degree above to learn more about it, and relevant contact information.";
    string AOAText = "The Associate of Arts degree is designed for transfer to other colleges and universities. Students who wish to earn a Bachelor of Arts or Bachelor of Science degree at any other institution can complete their first two years at WVU Parkersburg. \n\n This program is the foundation to the following majors: art, education, English, history, journalism, mathematics, music, philosophy, political science, psychology, religion, social work, sociology, Spanish, communications and theatre. \n\nAdvisor: Dave Thompson";
    string DCText = "The Associate of Applied Science in Digital Communication is a pathway to the Bachelor of Applied Science in Communication and Media Studies. This degree offers hands-on learning experiences in broadcast announcing, broadcast and video production and sports and news reporting. \n\n Students are also able to pursue a variety of service learning projects as they complete the requirements for these courses. \n\n Advisor: Olivia Reeder";
    string SCText = "Strategic communication students focus on the meld of good communication and planning with an organization. The term strategic communication is an umbrella term meant to include a variety of communication-related professions, such as public relations, branding, advertising and more. \n\n Advisor: Olivia Reeder";
    string MDSText = "The Bachelor of Arts in Multi-Disciplinary Studies degree provides a rigorous academic program with a strong foundation in the arts and sciences, providing preparation for graduate or professional degrees beyond the college’s other specialized and primarily professional/career-focused bachelor’s degree programs. Students in this program will choose three minors and combine these disciplines into a senior project their final semester of study. \n\n Advisor: H.G. Young";
    // Update is called once per frame
    void Update()
    {
        switch(HFASSDropdown.value)
        {

            case 0:
                InfoText.GetComponent<Text>().text = HFASSText;
                break;
            case 1:
                InfoText.GetComponent<Text>().text = AOAText;

                break;
            case 2:
                InfoText.GetComponent<Text>().text = DCText;
                break;
            case 3:
                InfoText.GetComponent<Text>().text = SCText;
                break;
            case 4:
                InfoText.GetComponent<Text>().text = MDSText;
                break;
         
        }
    }

}
