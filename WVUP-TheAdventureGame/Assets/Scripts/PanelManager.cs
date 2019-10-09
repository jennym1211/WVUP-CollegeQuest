using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelManager : MonoBehaviour
{
    public GameObject panel;
    public GameObject closeButton;


    private void Start()
    {
        closeButton.SetActive(false);
        panel.SetActive(false);
    }

    public void OpenPanel()
    {
        closeButton.SetActive(true);
        panel.SetActive(true);

    }


    public void ClosePanel()
    {

        panel.SetActive(false);
        closeButton.SetActive(false);

    }


}
