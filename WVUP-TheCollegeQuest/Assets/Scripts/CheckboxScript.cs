// ***********************************************************************
// Assembly         : Assembly-CSharp
// Author           : Jennifer
// Created          : 08-10-2020
//
// Last Modified By : Jennifer
// Last Modified On : 08-11-2020
// ***********************************************************************
// <copyright file="CheckboxScript.cs" company="">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Class CheckboxScript.
/// Implements the <see cref="UnityEngine.MonoBehaviour" />
/// </summary>
/// <seealso cref="UnityEngine.MonoBehaviour" />
public class CheckboxScript : MonoBehaviour
{
    /// <summary>
    /// The fafsa toggle
    /// </summary>
    public Toggle FAFSAToggle;

    /// <summary>
    /// The olsis toggle
    /// </summary>
    public Toggle OLSISToggle;

    /// <summary>
    /// The transcript toggle
    /// </summary>
    public Toggle TranscriptToggle;

    /// <summary>
    /// The continue button
    /// </summary>
    public GameObject ContinueButton;

    // Start is called before the first frame update
    /// <summary>
    /// Starts this instance.
    /// </summary>
    void Start()
    {
        ContinueButton.SetActive(false);
        Debug.Log("Continue button inactive.");
    }

    /// <summary>
    /// Updates this instance.
    /// </summary>
    void Update()
    {
        if (FAFSAToggle.isOn == true && OLSISToggle.isOn == true && TranscriptToggle.isOn == true)
        {
            ContinueButton.SetActive(true);
            Debug.Log("Continue button active.");
        }
        else
            ContinueButton.SetActive(false);
        Debug.Log("Continue button inactive.");
    }

    // Update is called once per frame
}