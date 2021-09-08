using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatSystem : MonoBehaviour
{
    public float height;
    public GameObject tank;
    
    private void Awake()
    {
        transform.position = new Vector3(0, height, 0);
    }

    private void FixedUpdate()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit, Mathf.Infinity))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.down) * hit.distance, Color.yellow);
            Debug.Log(hit.transform.localRotation.eulerAngles.x);
            tank.transform.eulerAngles = new Vector3(hit.transform.localRotation.eulerAngles.x, hit.transform.localRotation.eulerAngles.y + height, hit.transform.localRotation.eulerAngles.z);
        }
    }
}
