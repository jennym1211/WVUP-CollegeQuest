// ***********************************************************************
// Assembly         : Assembly-CSharp
// Author           : Jennifer
// Created          : 08-10-2020
//
// Last Modified By : Jennifer
// Last Modified On : 11-05-2020
// ***********************************************************************
// <copyright file="Player.cs" company="">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary>The player class represents the data involving the character the player controls.
//The main data attributes that the player class has includes Level, Name, and Major, which is imperative to
//the KIS (Knowledge Inventory System). On top of these data attributes, there are parts that are imperativve to the game system
//that involve the attributes (such as velocity) for move input, the rigidbody that sets the player up for appropriate collision detection, and
//others.
//
//</summary>
// ***********************************************************************
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.UI;

/// <summary>
/// Class Player.
/// Implements the <see cref="UnityEngine.MonoBehaviour" />
/// </summary>
/// <seealso cref="UnityEngine.MonoBehaviour" />
[Serializable]
public class Player : MonoBehaviour
{
    /// <summary>
    /// The instance
    /// </summary>
    public static Player instance;

    /// <summary>
    /// The character
    /// </summary>
    public GameObject character;

    /// <summary>
    /// The speed
    /// </summary>
    public float speed;

    /// <summary>
    /// The anim
    /// </summary>
    private Animator anim;

    /// <summary>
    /// The legs
    /// </summary>
    public SpriteRenderer legs;

    /// <summary>
    /// The dialog panel
    /// </summary>
    public GameObject dialogPanel;

    /// <summary>
    /// The rb
    /// </summary>
    public Rigidbody2D rb;

    /// <summary>
    /// The move velocity
    /// </summary>
    private Vector2 moveVelocity;

    /// <summary>
    /// The level
    /// </summary>
    private const string level = "Level";

    /// <summary>
    /// Gets or sets the level.
    /// </summary>
    /// <value>The level.</value>
    public string Level
    {
        get { return PlayerPrefs.GetString(level); }
        set
        {
            PlayerPrefs.SetString(level, value);
            Debug.Log("Player level set.");
        }
    }

    /// <summary>
    /// The name
    /// </summary>
    private const string name = "Name";

    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    /// <value>The name.</value>
    public string Name
    {
        get { return PlayerPrefs.GetString(name); }

        set
        {
            PlayerPrefs.SetString(name, value);
            Debug.Log("Player name set.");
        }
    }

    /// <summary>
    /// The major
    /// </summary>
    private const string major = "Major";

    /// <summary>
    /// Gets or sets the major.
    /// </summary>
    /// <value>The major.</value>
    public String Major
    {
        get { return PlayerPrefs.GetString(major); }

        set
        {
            PlayerPrefs.SetString(major, value);
            Debug.Log("Player major set.");
        }
    }

    /// <summary>
    /// The exp awarded
    /// </summary>
    private int expAwarded = 0;

    /// <summary>
    /// Gets or sets the exp awarded.
    /// </summary>
    /// <value>The exp awarded.</value>
    public int EXPAwarded
    {
        get { return PlayerPrefs.GetInt(expAwarded.ToString()); }
        set { PlayerPrefs.SetInt(expAwarded.ToString(), value); }
    }

    /*
     *  Creates a singleton instance of the player upon the "Awake" state the game, given there should only be ONE instance throughout the game of the player.
     */

    /// <summary>
    /// Awakes this instance.
    /// </summary>
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this);
            Destroy(character);
        }
    }

    /// <summary>
    /// Starts this instance.
    /// </summary>
    private void Start()
    {
        anim = legs.GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();

        Major = "Undecided";
        Level = "Prospective Student";
    }

    /*
     * The Update method is continuously checked throughout the game. For the instance of the player, this method is used to check the move input of the player.
     *
     * If there is move input detected, it plays the animation for the leg walk, and if it doesn't the walk animation stops. In certain scenes, the player is not allowed to
     * move.
     *
     *
     */

    /// <summary>
    /// Updates this instance.
    /// </summary>
    private void Update()
    {
        CheckScene();
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput.normalized * speed;
        //  float moveInputfloat = Input.GetAxisRaw("Horizontal");

        if (moveInput.x != 0 || moveInput.y != 0)
        {
            anim.SetBool("isWalking", true);
            Debug.Log("Player walking.");
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("CharacterCreation"))
        {
            Debug.Log("Character froze during character creation scene");
            anim.SetBool("isWalking", false);
        }
        else
        {
            anim.SetBool("isWalking", false);
            Debug.Log("Player stopped walking.");
        }
    }

    /// <summary>
    /// Checks the scene.
    /// </summary>
    public void CheckScene()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("KISScene"))
        {
            rb.velocity = Vector2.zero;
            anim.SetBool("isWalking", false);
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("CharacterCreation"))
        {
            rb.velocity = Vector2.zero;
            anim.SetBool("isWalking", false);
        }
        else
            rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }

    /// <summary>
    /// Freezes the player.
    /// </summary>
    public void FreezePlayer()
    {
        dialogPanel = GameObject.FindWithTag("DialogPanel");
        if (dialogPanel.activeInHierarchy == true)
        {
            rb.velocity = Vector2.zero;
            anim.SetBool("isWalking", false);
        }
        else
        {
            rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
        }
    }
}