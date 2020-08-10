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
    string AText = "The Bachelor of Science in Business Administration with a concentration in Accounting (BSBA) gives students a strong background in business skills and competencies by combining traditional curriculum and individual attention from professors who have experience in a variety of fields and industries. \n We are intent on giving you “real” business world knowledge, guiding you into career specializations that will provide strong earning potential and stability in the economic climate of the future. Advisors: Holly Dexter, Dana Lee, Lisa Wilkinson";
    // Update is called once per frame
    void Update()
    {
        switch(BAPSDropdown.value)
        {

            case 0:
                InfoText.GetComponent<Text>().text = BAPSText;
                break;
            case 1:
                InfoText.GetComponent<Text>().text = AText;

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
                InfoText.GetComponent<Text>().text = FillerText;
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
         
        }
    }

}
