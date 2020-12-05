// ***********************************************************************
// Assembly         : Assembly-CSharp
// Author           : Jennifer
// Created          : 10-05-2020
//
// Last Modified By : Jennifer
// Last Modified On : 10-06-2020
// ***********************************************************************
// <copyright file="Main.cs" company="">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class Main.
/// Implements the <see cref="UnityEngine.MonoBehaviour" />
/// </summary>
/// <seealso cref="UnityEngine.MonoBehaviour" />
public class Main : MonoBehaviour
{
    /// <summary>
    /// The instance
    /// </summary>
    public static Main Instance;

    /// <summary>
    /// The web
    /// </summary>
    public Web Web;

    // Start is called before the first frame update
    /// <summary>
    /// Starts this instance.
    /// </summary>
    private void Start()
    {
        Instance = this;
        Web = GetComponent<Web>();
    }
}