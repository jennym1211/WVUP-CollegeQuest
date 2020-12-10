// ***********************************************************************
// Assembly         : Assembly-CSharp
// Author           : Jennifer
// Created          : 08-10-2020
//
// Last Modified By : Jennifer
// Last Modified On : 09-14-2020
// ***********************************************************************
// <copyright file="QuestScript.cs" company="">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/// <summary>
/// Class QuestScript.
/// Implements the <see cref="UnityEngine.MonoBehaviour" />
/// </summary>
/// <seealso cref="UnityEngine.MonoBehaviour" />
public class QuestScript : MonoBehaviour
{
    /// <summary>
    /// The quest list
    /// </summary>
    public List<Quest> QuestList;

    /// <summary>
    /// The button list
    /// </summary>
    public List<GameObject> button_list = new List<GameObject>();

    /// <summary>
    /// The quest button
    /// </summary>
    public GameObject QuestButton;

    /// <summary>
    /// The quest information
    /// </summary>
    public GameObject QuestInfo;

    /// <summary>
    /// The admissions quest button
    /// </summary>
    GameObject AdmissionsQuestButton;

    /// <summary>
    /// The fa quest button
    /// </summary>
    public GameObject FAQuestButton;

    GameObject CSQuestButton;

    /// <summary>
    /// The scroll view
    /// </summary>
    public ScrollRect scrollView;

    /// <summary>
    /// The task list content
    /// </summary>
    public GameObject TaskListContent;

    // Start is called before the first frame update
    /// <summary>
    /// Starts this instance.
    /// </summary>
    void Start()
    {
        // CreateInitialQuestList();
        StartCoroutine(CreateQuests());

        CheckFinComplete();
        //CreateQuestButtons();
    }

    void Update()
    {
        StartCoroutine(CreateQuests());
        CheckFinComplete();
    }

    //Refactor CreateQuestButton And Delete This, this is Temporary
    /// <summary>
    /// Populates the quest buttons.
    /// </summary>
    public void PopulateQuestButtons()
    {
        AdmissionsQuestButton = GameObject.Find("AdmissionsButton");

        FAQuestButton = GameObject.Find("FAButton");
        CSQuestButton = GameObject.Find("CSButton");

        AdmissionsQuestButton.GetComponentInChildren<Text>().text = QuestList[0].QuestTitle;
        FAQuestButton.GetComponentInChildren<Text>().text = QuestList[1].QuestTitle;
        CSQuestButton.GetComponentInChildren<Text>().text = QuestList[2].QuestTitle;
    }

    /// <summary>
    /// Shows the quest information.
    /// </summary>
    public void ShowQuestInfo()
    {
        Button AB = AdmissionsQuestButton.GetComponent<Button>();
        Button FAB = FAQuestButton.GetComponent<Button>();
        Button CS = CSQuestButton.GetComponent<Button>();
        AB.onClick.AddListener(ShowAdmissionsInfo);
        FAB.onClick.AddListener(ShowFAInfo);
        CS.onClick.AddListener(ShowCSInfo);
    }

    /// <summary>
    /// Shows the admissions information.
    /// </summary>
    private void ShowAdmissionsInfo()
    {
        QuestInfo.GetComponent<Text>().text = QuestList[0].QuestInfo.ToString();
    }

    /// <summary>
    /// Shows the Financial Aid information.
    /// </summary>
    private void ShowFAInfo()
    {
        QuestInfo.GetComponent<Text>().text = QuestList[1].QuestInfo.ToString();
    }

    /// <summary>
    /// Shows the Financial Aid information.
    /// </summary>
    private void ShowCSInfo()
    {
        QuestInfo.GetComponent<Text>().text = QuestList[2].QuestInfo.ToString();
    }

    /// <summary>
    /// Creates the quest buttons.
    /// </summary>
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

    /// <summary>
    /// Creates the initial quest list from database
    /// </summary>
    private IEnumerator CreateQuests()
    {
        WWW request = new WWW("http://localhost/CollegeQuest/QuestTitleData.php");

        yield return request;

        string[] results = request.text.Split('\t');

        WWW infoRequest = new WWW("http://localhost/CollegeQuest/QuestInfoData.php");

        yield return request;

        string[] infoResults = infoRequest.text.Split('\t');

        Quest AdmissionQuest = new Quest(results[0], infoResults[0], 200);
        Quest FAQuest = new Quest(results[1], infoResults[1], 200);

        Quest CSQuest = new Quest(results[2], infoResults[2], 200);
        QuestList.Add(AdmissionQuest);
        QuestList.Add(FAQuest);
        QuestList.Add(CSQuest);

        if (request.isDone && infoRequest.isDone)
        {
            PopulateQuestButtons();

            scrollView.verticalNormalizedPosition = 1;
            ShowQuestInfo();

            if (SceneManager.GetActiveScene().name == "FinancialAid")
            {
                QuestList[1].IsCompleted = true;
                Player instance = FindObjectOfType<Player>();
                instance.EXPAwarded += 200;
                FAQuestButton.GetComponent<Image>().color = Color.gray;
            }
        }
    }

    public void CheckFinComplete()
    {
    }
}