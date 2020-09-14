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

    // Update is called once per frame
    void Update()
    {
        switch(HFASSDropdown.value)
        {

            case 0:
                InfoText.GetComponent<Text>().text = HFASSText;
                break;
         
        }
    }

}
