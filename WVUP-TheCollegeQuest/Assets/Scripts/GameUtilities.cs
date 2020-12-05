// ***********************************************************************
// Assembly         : Assembly-CSharp
// Author           : Jennifer
// Created          : 09-07-2020
//
// Last Modified By : Jennifer
// Last Modified On : 09-14-2020
// ***********************************************************************
// <copyright file="GameUtilities.cs" company="">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Class GameUtilities.
/// Implements the <see cref="UnityEngine.MonoBehaviour" />
/// </summary>
/// <seealso cref="UnityEngine.MonoBehaviour" />
public class GameUtilities : MonoBehaviour
{
    /// <summary>
    /// Quits this instance.
    /// </summary>
    public void Quit()
    {
        SceneManager.LoadScene("MainMenu");
    }
}