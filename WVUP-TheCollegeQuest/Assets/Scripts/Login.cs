// ***********************************************************************
// Assembly         : Assembly-CSharp
// Author           : Jennifer
// Created          : 10-05-2020
//
// Last Modified By : Jennifer
// Last Modified On : 10-06-2020
// ***********************************************************************
// <copyright file="Login.cs" company="">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Class Login.
/// Implements the <see cref="UnityEngine.MonoBehaviour" />
/// </summary>
/// <seealso cref="UnityEngine.MonoBehaviour" />
public class Login : MonoBehaviour
{
    /// <summary>
    /// The user name input
    /// </summary>
    public InputField userNameInput;

    /// <summary>
    /// The password input
    /// </summary>
    public InputField PasswordInput;

    /// <summary>
    /// The submit button
    /// </summary>
    public Button SubmitButton;

    // Start is called before the first frame update
    /// <summary>
    /// Starts this instance.
    /// </summary>
    private void Start()
    {
        SubmitButton.onClick.AddListener(() =>
        {
            StartCoroutine(Main.Instance.Web.Login(userNameInput.text, PasswordInput.text));
        });
    }

    // Update is called once per frame
    /// <summary>
    /// Updates this instance.
    /// </summary>
    private void Update()
    {
    }
}