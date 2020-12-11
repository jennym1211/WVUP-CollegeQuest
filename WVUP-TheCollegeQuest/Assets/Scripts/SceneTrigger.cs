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
using UnityEngine.UI;

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

    private Queue<Scene> sceneHistory = new Queue<Scene>();

    /// <summary>
    /// The player
    /// </summary>
    private Player player;

    /// <summary>
    /// The current scene
    /// </summary>
    private Scene currentScene;

    /// <summary>
    /// The previous scene
    /// </summary>
    private Scene previousScene;

    /// <summary>
    /// Called when a player collides with a certain object to transfer them to a different scene.
    /// </summary>
    /// <param name="collision">The collision.</param>
    public void OnTriggerEnter2D(Collider2D collision)
    {
        int index = sceneHistory.Count - 1;
        if (collision.CompareTag("Player"))
        {
            LoadScene(level);
            previousScene = sceneHistory.Peek();
            SetPosition(level);
            Debug.Log("Transitioning scenes...");

            Debug.Log("Previous scene" + sceneHistory.Peek().name);
        }
    }

    public void PreviousScene()
    {
        if (sceneHistory.Count > 0)
        {
            LoadScene(sceneHistory.Dequeue().name);
        }
    }

    public void LoadScene(string SceneName)
    {
        currentScene = SceneManager.GetActiveScene();
        sceneHistory.Enqueue(currentScene);
        sceneHistory.Enqueue(SceneManager.GetSceneByName(SceneName));
        SceneManager.LoadScene(SceneName);
    }

    /// <summary>
    /// Sets the position of the player depending on the scene they are in.
    /// </summary>
    public void SetPosition(string level)
    {
        player = FindObjectOfType<Player>();
        player.transform.localScale = new Vector2(1f, 1f);

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("CharacterCreation"))
        {
            Debug.Log("Setting player size while in creation mode...");
            player.transform.localScale = new Vector2(2f, 2f);
        }
        else if (level == SceneManager.GetSceneByName("CareerServices").name)
        {
            Debug.Log("Entering Career Services Scene, setting position.");
            player.transform.position = new Vector2(0f, -3.539998f);
        }
        else if (level == SceneManager.GetSceneByName("StudentServices").name)
        {
            Debug.Log("Entering Student Services Scene, setting position.");
            player.transform.position = new Vector2(-.3520007f, -3.5419f);
        }
        else if (level == SceneManager.GetSceneByName("FinancialAid").name)
        {
            QuestScript qs = FindObjectOfType<QuestScript>();

            qs.QuestList[1].IsCompleted = true;
            Player instance = FindObjectOfType<Player>();
            instance.EXPAwarded += 200;

            Debug.Log("Entering Student Services Scene, setting position.");
            player.transform.position = new Vector2(-.3520007f, -3.5419f);
        }
        else if (level == "Outside" && SceneManager.GetActiveScene().name == "InsideHallway")
        {
            Debug.Log("Previous scene is" + previousScene.name);
            Debug.Log("Entering Outside Scene, setting position.");
            player.transform.position = new Vector2(1.4f, -2.82f);
        }
        else if ((level == SceneManager.GetSceneByName("InsideHallway").name && SceneManager.GetActiveScene().name == "CareerServices"))
        {
            Debug.Log("Entering InsideHallway after exiting career services, setting position.");
            player.transform.position = new Vector2(-33.97773f, 10.13385f);
        }
        else if ((level == SceneManager.GetSceneByName("InsideHallway").name && SceneManager.GetActiveScene().name == "Outside"))
        {
            Debug.Log("Entering InsideHallway after exiting outside, setting position.");
            player.transform.position = new Vector2(-4.949746f, -25.52972f);
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("WelcomeScene"))
        {
            Debug.Log("Entering Welcome Scene, setting position.");
            player.transform.position = new Vector2(3.3f, .69f);
        }
        else if (level == SceneManager.GetSceneByName("BusinessOffice").name)
        {
            Debug.Log("Entering Business Office, setting position.");
            player.transform.position = new Vector2(-0.453f, .69f);
        }
        else if (level == SceneManager.GetSceneByName("InsideCaperton").name)
        {
            Debug.Log("Entering Caperton, setting position.");
            player.transform.position = new Vector2(-13.79f, 0.8f);
        }
        else if (level == SceneManager.GetSceneByName("InsideCaperton").name && SceneManager.GetActiveScene().name == "C127")
        {
            Debug.Log("Entering InsideHallway after exiting outside, setting position.");
            player.transform.position = new Vector2(-4.949746f, -25.52972f);
        }
        else if (level == SceneManager.GetSceneByName("C127").name)
        {
            Debug.Log("Entering C127, setting position.");
            player.transform.position = new Vector2(-9.90808f, 0.8f);
        }
        else if (level == SceneManager.GetSceneByName("Outside").name && SceneManager.GetActiveScene().name == "InsideCaperton")
        {
            Debug.Log("Previous scene is: " + previousScene.name);
            Debug.Log("Exiting Caperton, setting position.");
            player.transform.position = new Vector2(76.54f, 23.55f);
        }
        else
        {
            Debug.Log("Default scene position coordinates, setting position.");
            player.transform.position = new Vector2(0f, 0f);
            player.transform.localScale = new Vector2(1f, 1f);
        }
    }
}