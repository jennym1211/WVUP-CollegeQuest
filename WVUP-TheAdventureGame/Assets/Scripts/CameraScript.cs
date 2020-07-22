using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    GameObject player;
     Transform followObject;
   
    private Vector3 moveTemp;
    public float offsetY = 2;
    public float offsetX = 2;
    void Start()
    {
        player = GameObject.FindWithTag("Player");
       
    }

    // Update is called once per frame
    void Update()
    {
        followObject = player.transform;
        moveTemp = followObject.transform.position;
       
        moveTemp.y += offsetY;
        moveTemp.x += offsetX;
        moveTemp.z = transform.position.z;
        transform.position = moveTemp;
    }
}
