using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public static Player instance;
    public float speed;
    GameObject player;

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
        rb = GetComponent<Rigidbody2D>();
       


    }

    private void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput.normalized * speed;
       // setPosition();
      

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
