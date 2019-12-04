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


    public void OpenFAFSAURL()
    {

        Application.ExternalEval("window.open('https://studentaid.ed.gov/sa/fafsa');");

    }


    public void OpenOLSISURL()
    {

        Application.ExternalEval("window.open('https://rand.wvnet.edu:9920/WVUPPROD/twbkwbis.P_GenMenu?name=homepage');");

    }

    public void OpenTranscriptURL()
    {

        Application.ExternalEval("window.open(' https://www.wvup.edu/future-students/admissions/admissions-requirements/');");

    }

   

    private void Update()
    {
       
    }
}
