using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatSystem : MonoBehaviour
{
    public float height;

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
            Debug.Log(hit.transform.rotation.x);
            transform.eulerAngles = new Vector3(0, hit.transform.rotation.x, 0);
        }
    }
}
