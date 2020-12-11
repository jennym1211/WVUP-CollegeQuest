// ***********************************************************************
// Assembly         : Assembly-CSharp
// Author           : Jennifer
// Created          : 08-10-2020
//
// Last Modified By : Jennifer
// Last Modified On : 10-20-2020
// ***********************************************************************
// <copyright file="SceneManagement.cs" company="">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Class SceneManagement.
/// Implements the <see cref="UnityEngine.MonoBehaviour" />
/// </summary>
/// <seealso cref="UnityEngine.MonoBehaviour" />
public class SceneManagement : MonoBehaviour
{
    // Start is called before the first frame update

    /// <summary>
    /// The scene name
    /// </summary>
    protected Scene sceneName;

    /// <summary>
    /// The scene fa load increment
    /// </summary>
    protected int sceneFALoadIncrement = 0;

    /// <summary>
    /// Scenes the transition.
    /// </summary>
    /// <param name="sceneName">Name of the scene.</param>
    public void SceneTransition(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        Debug.Log("Transitioning scenes...");
        //SetPosition();
    }
}