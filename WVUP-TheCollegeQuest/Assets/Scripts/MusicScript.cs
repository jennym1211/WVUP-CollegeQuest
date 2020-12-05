// ***********************************************************************
// Assembly         : Assembly-CSharp
// Author           : Jennifer
// Created          : 08-10-2020
//
// Last Modified By : Jennifer
// Last Modified On : 08-11-2020
// ***********************************************************************
// <copyright file="MusicScript.cs" company="">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Class MusicScript.
/// Implements the <see cref="UnityEngine.MonoBehaviour" />
/// </summary>
/// <seealso cref="UnityEngine.MonoBehaviour" />
public class MusicScript : MonoBehaviour
{
    /// <summary>
    /// The audio source
    /// </summary>
    public AudioSource _audioSource;

    /// <summary>
    /// The music toggle
    /// </summary>
    GameObject[] MusicToggle;

    /// <summary>
    /// The instance
    /// </summary>
    static MusicScript instance = null;

    /// <summary>
    /// Awakes this instance.
    /// </summary>
    private void Awake()
    {
        MusicToggle = GameObject.FindGameObjectsWithTag("pause");

        foreach (GameObject pauseobj in MusicToggle)
        {
            pauseobj.SetActive(false);
        }
        if (instance != null)
        {
            Destroy(gameObject);
            Debug.Log("Instance has been destroyed.");
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(transform.gameObject);
            _audioSource = GetComponent<AudioSource>();
            Debug.Log("Setting audio source component");
        }
    }

    /// <summary>
    /// Plays the music.
    /// </summary>
    public void PlayMusic()
    {
        if (_audioSource.isPlaying) return;
        _audioSource.Play();
    }

    /// <summary>
    /// Mutes this instance.
    /// </summary>
    public void Mute()
    {
        AudioListener.pause = !AudioListener.pause;
        Debug.Log("Music has been paused.");
    }
}