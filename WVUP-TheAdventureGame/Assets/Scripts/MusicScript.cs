using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicScript : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioSource _audioSource;
    public Button MusicToggle;
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        _audioSource = GetComponent<AudioSource>();
    }

    public void PlayMusic()
    {
        if (_audioSource.isPlaying) return;
        _audioSource.Play();
    }

   public void Mute()
    {
        AudioListener.pause = !AudioListener.pause;

    }
}
