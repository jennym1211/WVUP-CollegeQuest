// ***********************************************************************
// Assembly         : Assembly-CSharp
// Author           : Jennifer
// Created          : 08-10-2020
//
// Last Modified By : Jennifer
// Last Modified On : 08-14-2020
// ***********************************************************************
// <copyright file="ShowSpeechBubble.cs" company="">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class ShowSpeechBubble.
/// Implements the <see cref="UnityEngine.MonoBehaviour" />
/// </summary>
/// <seealso cref="UnityEngine.MonoBehaviour" />
public class ShowSpeechBubble : MonoBehaviour
{
    /// <summary>
    /// The speech bubble
    /// </summary>
    public GameObject speechBubble;

    /// <summary>
    /// The sprite
    /// </summary>
    public SpriteRenderer sprite;

    /// <summary>
    /// Starts this instance.
    /// </summary>
    void Start()
    {
        speechBubble.SetActive(false);
    }

    /// <summary>
    /// Called when [mouse over].
    /// </summary>
    public void OnMouseOver()
    {
        speechBubble.SetActive(true);
    }

    /// <summary>
    /// Called when [mouse enter].
    /// </summary>
    private void OnMouseEnter()
    {
        speechBubble.SetActive(true);
    }

    // Update is called once per frame
    /// <summary>
    /// Called when [mouse exit].
    /// </summary>
    public void OnMouseExit()
    {
        speechBubble.SetActive(false);
    }
}