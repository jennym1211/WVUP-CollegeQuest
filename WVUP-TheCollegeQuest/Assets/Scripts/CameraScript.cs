// ***********************************************************************
// Assembly         : Assembly-CSharp
// Author           : Jennifer
// Created          : 08-10-2020
//
// Last Modified By : Jennifer
// Last Modified On : 08-11-2020
// ***********************************************************************
// <copyright file="CameraScript.cs" company="">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class CameraScript.
/// Implements the <see cref="UnityEngine.MonoBehaviour" />
/// </summary>
/// <seealso cref="UnityEngine.MonoBehaviour" />
public class CameraScript : MonoBehaviour
{
    /// <summary>
    /// The player
    /// </summary>
    GameObject player;

    /// <summary>
    /// The follow object
    /// </summary>
    Transform followObject;

    /// <summary>
    /// The move temporary
    /// </summary>
    private Vector3 moveTemp;

    /// <summary>
    /// The offset y
    /// </summary>
    public float offsetY = 2;

    /// <summary>
    /// The offset x
    /// </summary>
    public float offsetX = 2;

    /// <summary>
    /// Starts this instance.
    /// </summary>
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    /// <summary>
    /// Updates this instance.
    /// </summary>
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