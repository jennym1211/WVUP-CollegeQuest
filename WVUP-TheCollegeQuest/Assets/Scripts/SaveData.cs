// ***********************************************************************
// Assembly         : Assembly-CSharp
// Author           : Jennifer
// Created          : 08-10-2020
//
// Last Modified By : Jennifer
// Last Modified On : 07-21-2020
// ***********************************************************************
// <copyright file="SaveData.cs" company="">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

/// <summary>
/// Class SaveData.
/// Implements the <see cref="UnityEngine.MonoBehaviour" />
/// </summary>
/// <seealso cref="UnityEngine.MonoBehaviour" />
public class SaveData : MonoBehaviour
{
    /// <summary>
    /// The player
    /// </summary>
    private Player player;

    // Start is called before the first frame update
    /// <summary>
    /// Starts this instance.
    /// </summary>
    void Start()
    {
    }
}