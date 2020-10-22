using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class WebURLScript : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void OpenNewTab(string url);

    public void openURL(string url)
    {
#if !UNITY_EDITOR && UNITY_WEBGL
             OpenNewTab(url);
#endif
    }

    /**
     *
     * Uses javascript plugins to open links in a new tab.
     *
     */

    public void OpenURL(string url)
    {
        openURL(url);

        //   Application.ExternalEval("window.open('" + url + "');");
    }

    //public void OpenEMSICCURL()
    //{
    //    Application.ExternalEval("window.open('https://wvup.emsicc.com/');");
    //}
}