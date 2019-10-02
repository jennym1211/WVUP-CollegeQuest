using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    // Start is called before the first frame update

    public Scene sceneName;
        public enum Scene
    {
        CharacterCreation, WelcomeScene,FinancialAid, StudentServices,FinancialAidInfo, CareerServices, IfKnowDegree
    }
   public void SceneTransition(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
