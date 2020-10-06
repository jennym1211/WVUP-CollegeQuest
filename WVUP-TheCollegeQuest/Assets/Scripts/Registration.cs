using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Registration : MonoBehaviour
{
    public InputField nameField;
    public InputField passwordField;

    public Button SubmitButton;

    public void CallRegister()
    {
        StartCoroutine(Register());
    }

    private IEnumerator Register()
    {
        WWW www = new WWW("");
        yield return www;

        if (www.text == "0")
        {
            Debug.Log("User Created Successfully.");
        }
    }
}