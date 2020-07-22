using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowSpeechBubble : MonoBehaviour
{
    public GameObject speechBubble;
    
    void Start()
    {
        speechBubble.SetActive(false);
        
    }

    public void OnMouseOver()
    {
        speechBubble.SetActive(true);
    }

    // Update is called once per frame
    public void OnMouseExit()
    {
        speechBubble.SetActive(false);
    }
}
