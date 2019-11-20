using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebURLScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    public void OpenEMSICCURL()
    {

        Application.ExternalEval("window.open('https://wvup.emsicc.com/');");

    }

    public void OpenCNURL()
    {

        Application.ExternalEval("window.open('https://www.collegecentral.com/wvup/');");

    }




    public void OpenLIURL()
    {

        Application.ExternalEval("window.open('https://www.linkedin.com/');");

    }


   
    private void Update()
    {
       
    }
}
