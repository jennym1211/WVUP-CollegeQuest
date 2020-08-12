using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicScript : MonoBehaviour
{
    

    public AudioSource _audioSource;
    GameObject[] MusicToggle;
    static MusicScript instance = null;
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

    public void PlayMusic()
    {
        if (_audioSource.isPlaying) return;
        _audioSource.Play();
    }

   public void Mute()
    {
     
        AudioListener.pause = !AudioListener.pause;
        Debug.Log("Music has been paused.");

    }
}
