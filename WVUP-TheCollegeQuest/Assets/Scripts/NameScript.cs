// ***********************************************************************
// Assembly         : Assembly-CSharp
// Author           : Jennifer
// Created          : 08-10-2020
//
// Last Modified By : Jennifer
// Last Modified On : 07-21-2020
// ***********************************************************************
// <copyright file="NameScript.cs" company="">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Class NameScript.
/// Implements the <see cref="UnityEngine.MonoBehaviour" />
/// </summary>
/// <seealso cref="UnityEngine.MonoBehaviour" />
public class NameScript : MonoBehaviour
{
    /// <summary>
    /// The input field
    /// </summary>
    public GameObject inputField;

    /// <summary>
    /// The player
    /// </summary>
    private Player player;

    // Start is called before the first frame update

    /// <summary>
    /// Stores the name.
    /// </summary>
    public void StoreName()
    {
        player = FindObjectOfType<Player>();

        player.Name = inputField.GetComponent<Text>().text;
    }
}