using UnityEngine;
using UnityEngine.UI;

public class InteractionScript : MonoBehaviour
{
    // Start is called before the first frame update
    // public GameObject FAOfficer;
    public GameObject FACanvas;
    public GameObject Player;
    public SpriteRenderer FAOfficer;


    public void Start()
    {

        FACanvas.SetActive(false);
    }

    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "FAOfficerSprite")
        {
            {
                Debug.Log("Interaction detected");
                FACanvas.SetActive(true);
            }

        }


    }
}


