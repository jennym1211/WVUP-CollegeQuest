// ***********************************************************************
// Assembly         : Assembly-CSharp
// Author           : Jennifer
// Created          : 08-10-2020
//
// Last Modified By : Jennifer
// Last Modified On : 07-21-2020
// ***********************************************************************
// <copyright file="PanelManager.cs" company="">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Class PanelManager.
/// Implements the <see cref="UnityEngine.MonoBehaviour" />
/// </summary>
/// <seealso cref="UnityEngine.MonoBehaviour" />
public class PanelManager : MonoBehaviour
{
    /// <summary>
    /// The panel
    /// </summary>
    public GameObject panel;

    /// <summary>
    /// The close button
    /// </summary>
    public GameObject closeButton;

    /// <summary>
    /// Starts this instance.
    /// </summary>
    private void Start()
    {
        closeButton.SetActive(false);
        panel.SetActive(false);
    }

    /// <summary>
    /// Opens the panel.
    /// </summary>
    public void OpenPanel()
    {
        closeButton.SetActive(true);
        panel.SetActive(true);
    }

    /// <summary>
    /// Closes the panel.
    /// </summary>
    public void ClosePanel()
    {
        panel.SetActive(false);
        closeButton.SetActive(false);
    }
}