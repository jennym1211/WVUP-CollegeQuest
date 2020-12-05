// ***********************************************************************
// Assembly         : Assembly-CSharp
// Author           : Jennifer
// Created          : 08-10-2020
//
// Last Modified By : Jennifer
// Last Modified On : 10-20-2020
// ***********************************************************************
// <copyright file="SceneTrigger.cs" company="">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Class SceneTrigger.
/// Implements the <see cref="UnityEngine.MonoBehaviour" />
/// </summary>
/// <seealso cref="UnityEngine.MonoBehaviour" />
public class SceneTrigger : MonoBehaviour
{
    /// <summary>
    /// The level
    /// </summary>
    public string level;

    /// <summary>
    /// The scene
    /// </summary>
    protected SceneManagement scene;

    /// <summary>
    /// The player
    /// </summary>
    private Player player;

    /// <summary>
    /// The previous scene
    /// </summary>
    private string previousScene;

    /// <summary>
    /// The start position
    /// </summary>
    private Transform startPos;

    /// <summary>
    /// Called when [trigger enter2 d].
    /// </summary>
    /// <param name="collision">The collision.</param>
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene(level);
            SetPosition();
        }
    }

    /// <summary>
    /// Sets the position.
    /// </summary>
    public void SetPosition()
    {
        player = FindObjectOfType<Player>();
        player.transform.localScale = new Vector2(1f, 1f);

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("CharacterCreation"))
        {
            Debug.Log("Setting player size while in creation mode...");
            player.transform.localScale = new Vector2(2f, 2f);
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("CareerServices"))
        {
            Debug.Log("Entering Career Services Scene, setting position.");
            player.transform.position = new Vector2(0f, -3.539998f);
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("StudentServices"))
        {
            Debug.Log("Entering Student Services Scene, setting position.");
            player.transform.position = new Vector2(-.3520007f, -3.5419f);
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("TutoringCenter"))
        {
            Debug.Log("Entering Tutoring Center Scene, setting position.");
            player.transform.position = new Vector2(-3.326036f, -3.401925f);
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Outside"))
        {
            Debug.Log("Entering Outside Scene, setting position.");
            player.transform.position = new Vector2(1.4f, -2.82f);
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("InsideHallway") && previousScene == "CareerServices")
        {
            Debug.Log("Entering InsideHallway after exiting career services, setting position.");
            player.transform.position = new Vector2(-33.70527f, 8.513558f);
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("InsideHallway") && previousScene == "Outside")
        {
            Debug.Log("Entering InsideHallway after exiting outside, setting position.");
            player.transform.position = new Vector2(-4.949746f, -25.52972f);
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("WelcomeScene"))
        {
            Debug.Log("Entering Welcome Scene, setting position.");
            player.transform.position = new Vector2(3.3f, .69f);
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("BusinessOffice"))
        {
            Debug.Log("Entering Business Office, setting position.");
            player.transform.position = new Vector2(-0.453f, .69f);
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("InsideCaperton"))
        {
            Debug.Log("Entering Caperton, setting position.");
            player.transform.position = new Vector2(-13.79f, 0.8f);
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("InsideCaperton") && previousScene == "C127")
        {
            Debug.Log("Entering InsideHallway after exiting outside, setting position.");
            player.transform.position = new Vector2(-4.949746f, -25.52972f);
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("C127"))
        {
            Debug.Log("Entering C127, setting position.");
            player.transform.position = new Vector2(-9.90808f, 0.8f);
        }
        else
        {
            Debug.Log("Default scene position coordinates, setting position.");
            player.transform.position = new Vector2(0f, 0f);
            player.transform.localScale = new Vector2(1f, 1f);
        }
    }
}