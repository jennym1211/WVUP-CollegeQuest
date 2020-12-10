// ***********************************************************************
// Assembly         : Assembly-CSharp
// Author           : Jennifer
// Created          : 08-10-2020
//
// Last Modified By : Jennifer
// Last Modified On : 07-21-2020
// ***********************************************************************
// <copyright file="InteractionScript.cs" company="">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Class InteractionScript.
/// Implements the <see cref="UnityEngine.MonoBehaviour" />
/// </summary>
/// <seealso cref="UnityEngine.MonoBehaviour" />
public class InteractionScript : MonoBehaviour
{
    // Start is called before the first frame update
    // public GameObject FAOfficer;
    /// <summary>
    /// The fa canvas
    /// </summary>
    public GameObject FACanvas;

    /// <summary>
    /// The player
    /// </summary>
    public GameObject Player;

    /// <summary>
    /// The fa officer
    /// </summary>
    public SpriteRenderer FAOfficer;

    /// <summary>
    /// Starts this instance.
    /// </summary>
    public void Start()
    {
        FACanvas.SetActive(false);
    }

    /// <summary>
    /// Called when [collision enter].
    /// </summary>
    /// <param name="col">The col.</param>
    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("FAOfficerSprite"))
        {
            {
                Debug.Log("Interaction detected");
                FACanvas.SetActive(true);
            }
        }
    }
}