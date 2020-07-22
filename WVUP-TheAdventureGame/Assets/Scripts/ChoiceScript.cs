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
    public Button continueButton;
    public GameObject ChoicePanel;

    void Start()
    {
        continueButton.gameObject.SetActive(false);

    }

    public void ChoiceOptionYes()
    {
        TextBox.GetComponent<Text>().text = "Alright, continue onto student services like I mentioned. See you there!";
        ChoiceMade = 1;
        continueButton.gameObject.SetActive(true);

    }


    public void ChoiceOptionNo()
    {

        TextBox.GetComponent<Text>().text = "Alright, then instead, let's instead make a stop at Career Services! Follow the signs inside, and I'll see you inside!";
        ChoiceMade = 2;
        continueButton.gameObject.SetActive(true);



    }

    void OnEnable()
    {
       continueButton.onClick.AddListener(() => ContinueButtonClick());
       
    }

    void ContinueButtonClick()
    {
        
            ChoiceNo.SetActive(false);
            ChoiceYes.SetActive(false);
            ChoicePanel.SetActive(false);
            continueButton.gameObject.SetActive(false);



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
