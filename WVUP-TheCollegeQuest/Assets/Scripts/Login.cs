using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    public InputField userNameInput;
    public InputField PasswordInput;
    public Button SubmitButton;

    // Start is called before the first frame update
    private void Start()
    {
        SubmitButton.onClick.AddListener(() =>
        {
            StartCoroutine(Main.Instance.Web.Login(userNameInput.text, PasswordInput.text));
        });
    }

    // Update is called once per frame
    private void Update()
    {
    }
}