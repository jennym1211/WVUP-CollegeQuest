// ***********************************************************************
// Assembly         : Assembly-CSharp
// Author           : Jennifer
// Created          : 11-18-2020
//
// Last Modified By : Jennifer
// Last Modified On : 11-19-2020
// ***********************************************************************
// <copyright file="WWWDialogueScript.cs" company="">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

/// <summary>
/// Class WWWDialogueScript.
/// Implements the <see cref="UnityEngine.MonoBehaviour" />
/// </summary>
/// <seealso cref="UnityEngine.MonoBehaviour" />
public class WWWDialogueScript : MonoBehaviour
{
    /// <summary>
    /// The text object
    /// </summary>
    public Text textObject;

    /// <summary>
    /// The PHP link
    /// </summary>
    public string phpLink;

    /// <summary>
    /// Starts this instance.
    /// </summary>
    private void Start()
    {
        StartCoroutine(GetDialogueData(phpLink));
        //StartCoroutine(Login("testplayer1", "password"));
    }

    /// <summary>
    /// Gets the dialogue data.
    /// </summary>
    /// <param name="phpLink">The PHP link.</param>
    /// <returns>IEnumerator.</returns>
    public IEnumerator GetDialogueData(string phpLink)
    {
        using (UnityWebRequest www = UnityWebRequest.Get(phpLink))
        {
            yield return www.Send();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);

                byte[] results = www.downloadHandler.data;

                textObject.text = www.downloadHandler.text;
            }
        }
    }
}