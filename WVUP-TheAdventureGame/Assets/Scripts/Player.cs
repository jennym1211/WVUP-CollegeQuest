using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public static Player instance;
    public float speed;
    GameObject player;
    Animator anim;
    public SpriteRenderer legs;
    private Vector3 newPos = new Vector3(0, 0, 0);
  
    private Rigidbody2D rb;
    private Vector2 moveVelocity;

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
        setPosition();
    }

    
    void Start()
    {
        anim = legs.GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
       


    }

    private void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput.normalized * speed;
      //  float moveInputfloat = Input.GetAxisRaw("Horizontal");

        if (moveInput.x != 0|| moveInput.y !=0)
        {
            anim.SetBool("isWalking", true);
        }
        else
        {
            anim.SetBool("isWalking", false);
        }

    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
        
    }


    public void setPosition()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("CareerServices"))
        {

            player = GameObject.FindWithTag("Player");
            player.transform.position = newPos;
           



        }

    }

}
