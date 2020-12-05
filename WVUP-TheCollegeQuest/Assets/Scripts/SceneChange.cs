// ***********************************************************************
// Assembly         : Assembly-CSharp
// Author           : Jennifer
// Created          : 10-06-2020
//
// Last Modified By : Jennifer
// Last Modified On : 10-06-2020
// ***********************************************************************
// <copyright file="SceneChange.cs" company="">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Class SceneChange.
/// Implements the <see cref="UnityEngine.MonoBehaviour" />
/// </summary>
/// <seealso cref="UnityEngine.MonoBehaviour" />
public class SceneChange : MonoBehaviour
{
    /// <summary>
    /// The scene name
    /// </summary>
    protected Scene sceneName;

    // Start is called before the first frame update
    /// <summary>
    /// Changes the scene.
    /// </summary>
    /// <param name="sceneName">Name of the scene.</param>
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        Debug.Log("Transitioning scenes...");
    }
}