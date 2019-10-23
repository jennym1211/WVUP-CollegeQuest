using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebURLScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    public void OpenURL(string URL)
    {
        Application.OpenURL(URL);
    }

    private void Update()
    {
       
    }
}
