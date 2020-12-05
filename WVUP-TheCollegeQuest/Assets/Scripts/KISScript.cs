// ***********************************************************************
// Assembly         : Assembly-CSharp
// Author           : Jennifer
// Created          : 08-10-2020
//
// Last Modified By : Jennifer
// Last Modified On : 09-14-2020
// ***********************************************************************
// <copyright file="KISScript.cs" company="">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Class KISScript.
/// Implements the <see cref="UnityEngine.MonoBehaviour" />
/// </summary>
/// <seealso cref="UnityEngine.MonoBehaviour" />
public class KISScript : MonoBehaviour
{
    /// <summary>
    /// The level text
    /// </summary>
    public Text levelText;

    /// <summary>
    /// The major text
    /// </summary>
    public Text majorText;

    /// <summary>
    /// The name text
    /// </summary>
    public Text nameText;

    /// <summary>
    /// The exp text
    /// </summary>
    public Text EXPText;

    /// <summary>
    /// The player
    /// </summary>
    private Player player;

    // Start is called before the first frame update

    /// <summary>
    /// Starts this instance.
    /// </summary>
    public void Start()
    {
        player = FindObjectOfType<Player>();
        nameText.text = player.Name;
        levelText.text = player.Level;
        majorText.text = player.Major;
        EXPText.text = player.EXPAwarded.ToString();

        player.transform.localScale = new Vector2(1.5f, 1.5f);
        player.transform.position = new Vector2(-.35f, 3.3f);
    }
}