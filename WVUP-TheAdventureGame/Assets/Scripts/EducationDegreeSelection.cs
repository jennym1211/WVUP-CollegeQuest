using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EducationDegreeSelection : MonoBehaviour
{
    public Dropdown EduDropdown;
    public GameObject InfoText;
     string FillerText = "This is filler text for now";
    string EduText = "The Education Division is committed to creating an exemplary workforce to help shape our community, state and nation’s future…our children. WVU Parkersburg offers a variety of educational opportunities for students interested in a career in education. Our elementary program is based on the premise that the best place for pre-service teachers to learn about teaching is in public school classrooms. For this reason, you will begin working in a classroom as early as your freshman year. \n Select a degree above to learn more about it, and relevant contact information.";
    // Update is called once per frame
    void Update()
    {
        switch(EduDropdown.value)
        {

            case 0:
                InfoText.GetComponent<Text>().text = EduText;
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
            
        }
    }
}
