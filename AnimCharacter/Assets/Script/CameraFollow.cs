using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = new Vector3(0, target.position.y, -10f);
        transform.position = Vector3.Slerp(transform.position, newPos, Time.deltaTime);
    }
}