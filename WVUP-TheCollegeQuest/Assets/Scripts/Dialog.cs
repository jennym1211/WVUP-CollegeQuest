// ***********************************************************************
// Assembly         : Assembly-CSharp
// Author           : Jennifer
// Created          : 08-10-2020
//
// Last Modified By : Jennifer
// Last Modified On : 08-13-2020
// ***********************************************************************
// <copyright file="Dialog.cs" company="">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

/// <summary>
/// Class Dialog.
/// Implements the <see cref="UnityEngine.MonoBehaviour" />
/// </summary>
/// <seealso cref="UnityEngine.MonoBehaviour" />
public class Dialog : MonoBehaviour
{
    /// <summary>
    /// The text display
    /// </summary>
    public TextMeshProUGUI textDisplay;

    /// <summary>
    /// The sentences
    /// </summary>
    public string[] sentences;

    /// <summary>
    /// The index
    /// </summary>
    private int index;

    /// <summary>
    /// The typing speed
    /// </summary>
    public float typingSpeed;

    /// <summary>
    /// The head shot
    /// </summary>
    public SpriteRenderer headShot;

    /// <summary>
    /// The continue button
    /// </summary>
    public GameObject continueButton;

    /// <summary>
    /// The dialog panel
    /// </summary>
    public GameObject dialogPanel;

    /// <summary>
    /// Updates this instance.
    /// </summary>
    private void Update()
    {
        if (textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);
            Debug.Log("Continue button active.");
        }
    }

    /// <summary>
    /// Starts this instance.
    /// </summary>
    void Start()
    {
        continueButton.SetActive(false);
        Debug.Log("Continue button inactive.");
        StartCoroutine(Type());
    }

    /// <summary>
    /// Types this instance.
    /// </summary>
    /// <returns>IEnumerator.</returns>
    IEnumerator Type()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    /// <summary>
    /// Nexts the sentence.
    /// </summary>
    public void NextSentence()
    {
        continueButton.SetActive(false);
        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            textDisplay.text = "";
            headShot.enabled = false;
            continueButton.SetActive(false);
            dialogPanel.SetActive(false);
        }
    }
}