// ***********************************************************************
// Assembly         : Assembly-CSharp
// Author           : Jennifer
// Created          : 08-10-2020
//
// Last Modified By : Jennifer
// Last Modified On : 10-20-2020
// ***********************************************************************
// <copyright file="SceneManagement.cs" company="">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Class SceneManagement.
/// Implements the <see cref="UnityEngine.MonoBehaviour" />
/// </summary>
/// <seealso cref="UnityEngine.MonoBehaviour" />
public class SceneManagement : MonoBehaviour
{
    // Start is called before the first frame update

    /// <summary>
    /// The scene name
    /// </summary>
    protected Scene sceneName;

    /// <summary>
    /// The current scene
    /// </summary>
    private string currentScene;

    /// <summary>
    /// The scene fa load increment
    /// </summary>
    protected int sceneFALoadIncrement = 0;

    /// <summary>
    /// The player
    /// </summary>
    private Player player;

    /// <summary>
    /// The character
    /// </summary>
    private GameObject character;

    /// <summary>
    /// The current quest
    /// </summary>
    private Quest currentQuest;

    /// <summary>
    /// The previous scene
    /// </summary>
    private string previousScene;

    /// <summary>
    /// The scene history
    /// </summary>
    private List<string> sceneHistory = new List<string>();

    /// <summary>
    /// Scenes the transition.
    /// </summary>
    /// <param name="sceneName">Name of the scene.</param>
    public void SceneTransition(string sceneName)
    {
        currentScene = SceneManager.GetActiveScene().name;
        sceneHistory.Add(currentScene);
        sceneHistory.Add(sceneName);

        SceneManager.LoadScene(sceneName);
        Debug.Log("Transitioning scenes...");
        SetPosition();
    }

    /// <summary>
    /// Awakes this instance.
    /// </summary>
    protected void Awake()
    {
        SetPosition();
    }

    /// <summary>
    /// Starts this instance.
    /// </summary>
    public void Start()
    {
        // previousScene = SceneManager.GetActiveScene().name;
        SetPosition();
    }

    /// <summary>
    /// Loads the previous scene.
    /// </summary>
    public void LoadPreviousScene()
    {
        if (sceneHistory.Count >= 2)
        {
            sceneHistory.RemoveAt(sceneHistory.Count - 1);
            SceneManager.LoadScene(sceneHistory[sceneHistory.Count - 1]);
        }
        //SceneManager.LoadScene(previousScene);
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
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("MainMenu"))
        {
            character = GameObject.FindGameObjectWithTag("Player");
            Destroy(character);
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("FinancialAid"))
        {
            sceneFALoadIncrement += 1;
            if (currentQuest.QuestTitle == "FAQuest")
            {
                currentQuest.IsCompleted = true;
                player.EXPAwarded += currentQuest.EXP;
            }
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("InsideCaperton"))
        {
            Debug.Log("Entering Caperton, setting position.");
            player.transform.position = new Vector2(-13.79f, 0.8f);
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