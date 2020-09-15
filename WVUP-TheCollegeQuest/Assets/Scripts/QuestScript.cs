using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestScript : MonoBehaviour
{

    public List<Quest> QuestList;
    public List<GameObject> button_list = new List<GameObject>();
    public GameObject QuestButton;
    public GameObject QuestInfo;
    GameObject AdmissionsQuestButton;
    GameObject FAQuestButton;

    public ScrollRect scrollView;
    public GameObject TaskListContent;
    // Start is called before the first frame update
    void Start()
    {
        CreateInitialQuestList();
        //CreateQuestButtons();
        PopulateQuestButtons();
        scrollView.verticalNormalizedPosition = 1;
        ShowQuestInfo();
    }


    //Refactor CreateQuestButton And Delete This, this is Temporary
    public void PopulateQuestButtons()
    {
     

        AdmissionsQuestButton = GameObject.Find("AdmissionsButton");

        FAQuestButton = GameObject.Find("FAButton");


        AdmissionsQuestButton.GetComponentInChildren<Text>().text = QuestList[0].QuestTitle;
        FAQuestButton.GetComponentInChildren<Text>().text = QuestList[1].QuestTitle;

    }

    public void ShowQuestInfo()
    {
        Button AB = AdmissionsQuestButton.GetComponent<Button>();
        Button FAB = FAQuestButton.GetComponent<Button>();
        AB.onClick.AddListener(ShowAdmissionsInfo);
        FAB.onClick.AddListener(ShowFAInfo);

       
    }

  
    private void ShowAdmissionsInfo()
    {
        QuestInfo.GetComponent<Text>().text = QuestList[0].QuestInfo.ToString();
    }


    private void ShowFAInfo()
    {
        QuestInfo.GetComponent<Text>().text = QuestList[1].QuestInfo.ToString();
    }


    public void CreateQuestButtons()
    {


        foreach (Quest q in QuestList)
        {
            // TaskList = GameObject.Find("TaskList");

            GameObject questbutton = Instantiate(QuestButton);    

           
            questbutton.transform.SetParent(TaskListContent.transform, false);
            questbutton.transform.localScale = new Vector3(1, 1, 1);

            questbutton.name = q.QuestTitle;
            questbutton.GetComponentInChildren<Text>().text = q.QuestTitle;
            

            button_list.Add(questbutton);
         


        }

     

    }


    private void CreateInitialQuestList()
    {
        string QString1 = "You must head to Student Services to learn the process of getting admitted.";
        string QString2 = "You must head to Student Services, and learn about the ins and outs of financial aid!";

        Quest AdmissionQuest = new Quest("The Road To Admissions", QString1, 200);
        Quest FAQuest = new Quest("The Search for Financial Aid", QString2, 200);
        QuestList.Add(AdmissionQuest);
        QuestList.Add(FAQuest);
    }

}
