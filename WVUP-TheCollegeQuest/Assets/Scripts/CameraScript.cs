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
        Debug.Log("Y=" + moveTemp.y.ToString());
        moveTemp.x += offsetX;
        Debug.Log("X=" + moveTemp.x.ToString());
        moveTemp.z = transform.position.z;
        Debug.Log("Z=" + moveTemp.z.ToString());
        transform.position = moveTemp;
    }
}
