using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class FinDataDialog : MonoBehaviour
{
    public TextMeshProUGUI textBox;
    public string phpLink;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GetFinIntroData(phpLink, textBox));
        //StartCoroutine(GetLoanData("http://localhost/CollegeQuest/GetLoanInfo.php"));
        //StartCoroutine(GetLoanData("http://localhost/CollegeQuest/GetLoanInfo.php"));
    }

    void Update()
    {
        StartCoroutine(GetFinIntroData(phpLink, textBox));
    }

    /// <summary>
    /// Gets the dialogue data.
    /// </summary>
    /// <param name="phpLink">The PHP link.</param>
    /// <returns>IEnumerator.</returns>
    public IEnumerator GetFinIntroData(string phpLink, TextMeshProUGUI textBox)
    {
        using (UnityWebRequest www = UnityWebRequest.Get(phpLink))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);

                byte[] results = www.downloadHandler.data;

                textBox.text = www.downloadHandler.text;
            }
        }
    }
}