using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
     GameObject player = GameObject.FindWithTag("Player");
     Transform followObject;
   
    private Vector3 moveTemp;
    public float offsetY = 2;
    public float offsetX = 2;
    void Start()
    {
        followObject = player.transform;
        moveTemp = followObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        moveTemp = followObject.transform.position;
        moveTemp.y += offsetY;
        moveTemp.x += offsetX;
        moveTemp.z = transform.position.z;
        transform.position = moveTemp;
    }
}
