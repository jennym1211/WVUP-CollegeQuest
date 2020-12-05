// ***********************************************************************
// Assembly         : Assembly-CSharp
// Author           : Jennifer
// Created          : 08-10-2020
//
// Last Modified By : Jennifer
// Last Modified On : 10-22-2020
// ***********************************************************************
// <copyright file="WebURLScript.cs" company="">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

/// <summary>
/// Class WebURLScript.
/// Implements the <see cref="UnityEngine.MonoBehaviour" />
/// </summary>
/// <seealso cref="UnityEngine.MonoBehaviour" />
public class WebURLScript : MonoBehaviour
{
    /// <summary>
    /// Opens the new tab.
    /// </summary>
    /// <param name="url">The URL.</param>
    [DllImport("__Internal")]
    private static extern void OpenNewTab(string url);

    /// <summary>
    /// Opens the URL.
    /// </summary>
    /// <param name="url">The URL.</param>
    public void openURL(string url)
    {
#if !UNITY_EDITOR && UNITY_WEBGL
             OpenNewTab(url);
#endif
    }

    /**
     *
     * Uses javascript plugins to open links in a new tab.
     *
     */

    /// <summary>
    /// Opens the URL.
    /// </summary>
    /// <param name="url">The URL.</param>
    public void OpenURL(string url)
    {
        openURL(url);

        //   Application.ExternalEval("window.open('" + url + "');");
    }
}