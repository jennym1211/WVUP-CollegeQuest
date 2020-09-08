using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.UI;


[Serializable]
public class Player : MonoBehaviour
{
    public static Player instance;
    public float speed;
    Animator anim;
    public SpriteRenderer legs;
    public GameObject dialogPanel;
    public Rigidbody2D rb;
    private Vector2 moveVelocity;
    private const string level = "Level";

    public string Level
    {
        get { return PlayerPrefs.GetString(level); }
        set { PlayerPrefs.SetString(level, value);
            Debug.Log("Player level set.");
        }
    }

    private const string name = "Name";
    public string Name
    {
        get { return PlayerPrefs.GetString(name); }

        set { PlayerPrefs.SetString(name, value);
            Debug.Log("Player name set.");
        }

    }

    private const string major = "Major";
    public String Major
    {
        get { return PlayerPrefs.GetString(major); }

    
        set { PlayerPrefs.SetString(major, value);
            Debug.Log("Player major set.");
        }


    }

   void Awake()
    {

       

        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
      
        else
        {
            Destroy(this);
        }
     
        
    }

    
    void Start()
    {
        anim = legs.GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();

        Major = "Undecided";
        Level = "Prospective Student";

     
    }



    private void Update()
    {
        CheckScene();
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput.normalized * speed;
        //  float moveInputfloat = Input.GetAxisRaw("Horizontal");
        
        if (moveInput.x != 0 || moveInput.y != 0)
        {
            anim.SetBool("isWalking", true);
            Debug.Log("Player walking.");
        }
        else
        {
            anim.SetBool("isWalking", false);
            Debug.Log("Player stopped walking.");
        }


    }


    public void CheckScene()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("KISScene"))
        {
            rb.velocity = Vector2.zero;
            anim.SetBool("isWalking", false);
        }
      
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("CharacterCreation"))
        {
            rb.velocity = Vector2.zero;
            anim.SetBool("isWalking", false);
        }
      
        else
            rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);



       
    }

    public void FreezePlayer()
    {
        

        dialogPanel = GameObject.FindWithTag("DialogPanel");
        if (dialogPanel.activeInHierarchy == true)
        {
            rb.velocity = Vector2.zero;
            anim.SetBool("isWalking", false);
        }
        else
        {
            rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
        }

    }

    public void Save(int SaveSlot)
    {
        PlayerPrefs.SetString("SaveSlot_" + SaveSlot.ToString() + "_" + name, Name);
        PlayerPrefs.SetString("SaveSlot_" + SaveSlot.ToString() + "_" + level, Level);
        PlayerPrefs.SetString("SaveSlot_" + SaveSlot.ToString() + "_" + major, Major);
        Debug.Log("Player information saved.");

    }

    public void Load(int SaveSlot)
    {
        Name = PlayerPrefs.GetString("SaveSlot_" + SaveSlot.ToString() + "_" + name, Name);
        Level = PlayerPrefs.GetString("SaveSlot_" + SaveSlot.ToString() + "_" + level, Level);
        Major = PlayerPrefs.GetString("SaveSlot_" + SaveSlot.ToString() + "_" + major, Major);
        Debug.Log("Player information loaded.");
    }


}
