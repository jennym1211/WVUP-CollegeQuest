using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    // Start is called before the first frame update

    protected Scene sceneName;
    string previousScene;
    private Player player;
   
    public void SceneTransition(string sceneName)
    {
        previousScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(sceneName);
       
    }

   public void Start()
    {
        previousScene = SceneManager.GetActiveScene().name;
        SetPosition();
    }



    public void LoadPreviousScene()
    {
       
        SceneManager.LoadScene(previousScene);
    }

    public void SetPosition()
    {
        player = FindObjectOfType<Player>();
        player.transform.localScale = new Vector2(1f, 1f);

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("CharacterCreation"))
        {
            player.transform.localScale = new Vector2(2f, 2f);
        }
       else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("CareerServices"))
        {
          
            player.transform.position = new Vector2(0f, -3.539998f);

        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Outside"))
        {
            player.transform.position = new Vector2(1.4f, -2.82f);
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("InsideHallway") && previousScene == "CareerServices")
        {
            player.transform.position = new Vector2(-33.70527f, 8.513558f);
        }

        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("InsideHallway") && previousScene == "Outside")
        {
            player.transform.position = new Vector2(-4.949746f, -25.52972f);
        }

        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("WelcomeScene")) { 
            player.transform.position = new Vector2(3.3f, .69f);
        }
        else
        {
            player.transform.position = new Vector2(0f, 0f);
            player.transform.localScale = new Vector2(1f, 1f);
        }
    }


}
