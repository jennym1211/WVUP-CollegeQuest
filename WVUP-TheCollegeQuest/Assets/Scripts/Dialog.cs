using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Dialog : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    public SpriteRenderer headShot;
    public GameObject continueButton;
    public GameObject dialogPanel;
 


    private void Update()
    {
        if (textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);
            Debug.Log("Continue button active.");
        }
    }
    void Start()
    {
        continueButton.SetActive(false);
        Debug.Log("Continue button inactive.");
        StartCoroutine(Type());

    }
    IEnumerator Type()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void NextSentence()
    {
        continueButton.SetActive(false);
        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            textDisplay.text = "";
            headShot.enabled = false;
            continueButton.SetActive(false);
            dialogPanel.SetActive(false);
        }
    }


}


