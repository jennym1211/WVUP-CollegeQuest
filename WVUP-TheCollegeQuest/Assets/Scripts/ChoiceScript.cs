// ***********************************************************************
// Assembly         : Assembly-CSharp
// Author           : Jennifer
// Created          : 08-10-2020
//
// Last Modified By : Jennifer
// Last Modified On : 07-21-2020
// ***********************************************************************
// <copyright file="ChoiceScript.cs" company="">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Class ChoiceScript.
/// Implements the <see cref="UnityEngine.MonoBehaviour" />
/// </summary>
/// <seealso cref="UnityEngine.MonoBehaviour" />
public class ChoiceScript : MonoBehaviour
{
    /// <summary>
    /// The text box
    /// </summary>
    public GameObject TextBox;

    /// <summary>
    /// The choice yes
    /// </summary>
    public GameObject ChoiceYes;

    /// <summary>
    /// The choice no
    /// </summary>
    public GameObject ChoiceNo;

    /// <summary>
    /// The choice made
    /// </summary>
    public int ChoiceMade;

    /// <summary>
    /// The continue button
    /// </summary>
    public Button continueButton;

    /// <summary>
    /// The choice panel
    /// </summary>
    public GameObject ChoicePanel;

    /// <summary>
    /// Starts this instance.
    /// </summary>
    void Start()
    {
        continueButton.gameObject.SetActive(false);
    }

    /// <summary>
    /// Choices the option yes.
    /// </summary>
    public void ChoiceOptionYes()
    {
        TextBox.GetComponent<Text>().text = "Alright, continue onto student services like I mentioned. See you there!";
        ChoiceMade = 1;
        continueButton.gameObject.SetActive(true);
    }

    /// <summary>
    /// Choices the option no.
    /// </summary>
    public void ChoiceOptionNo()
    {
        TextBox.GetComponent<Text>().text = "Alright, then instead, let's instead make a stop at Career Services! Follow the signs inside, and I'll see you inside!";
        ChoiceMade = 2;
        continueButton.gameObject.SetActive(true);
    }

    /// <summary>
    /// Called when [enable].
    /// </summary>
    void OnEnable()
    {
        continueButton.onClick.AddListener(() => ContinueButtonClick());
    }

    /// <summary>
    /// Continues the button click.
    /// </summary>
    void ContinueButtonClick()
    {
        ChoiceNo.SetActive(false);
        ChoiceYes.SetActive(false);
        ChoicePanel.SetActive(false);
        continueButton.gameObject.SetActive(false);
    }

    // Update is called once per frame
    /// <summary>
    /// Updates this instance.
    /// </summary>
    void Update()
    {
        if (ChoiceMade >= 1)
        {
            ChoiceYes.SetActive(false);
            ChoiceNo.SetActive(false);
        }
    }
}