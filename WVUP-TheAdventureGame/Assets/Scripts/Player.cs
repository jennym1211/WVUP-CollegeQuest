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

    public String Level

    {
        get;

        set;
    }

    public string Name
    {
        get;

       set;

    }

    public String Major
    {
        get;
        set;

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
        }
        else
        {
            anim.SetBool("isWalking", false);
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






}
