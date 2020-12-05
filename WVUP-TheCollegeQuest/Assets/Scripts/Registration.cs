// ***********************************************************************
// Assembly         : Assembly-CSharp
// Author           : Jennifer
// Created          : 10-03-2020
//
// Last Modified By : Jennifer
// Last Modified On : 10-03-2020
// ***********************************************************************
// <copyright file="Registration.cs" company="">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Class Registration.
/// Implements the <see cref="UnityEngine.MonoBehaviour" />
/// </summary>
/// <seealso cref="UnityEngine.MonoBehaviour" />
public class Registration : MonoBehaviour
{
    /// <summary>
    /// The name field
    /// </summary>
    public InputField nameField;

    /// <summary>
    /// The password field
    /// </summary>
    public InputField passwordField;

    /// <summary>
    /// The submit button
    /// </summary>
    public Button SubmitButton;

    /// <summary>
    /// Calls the register.
    /// </summary>
    public void CallRegister()
    {
        StartCoroutine(Register());
    }

    /// <summary>
    /// Registers this instance.
    /// </summary>
    /// <returns>IEnumerator.</returns>
    private IEnumerator Register()
    {
        WWW www = new WWW("");
        yield return www;

        if (www.text == "0")
        {
            Debug.Log("User Created Successfully.");
        }
    }
}