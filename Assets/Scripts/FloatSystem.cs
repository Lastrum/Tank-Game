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
        tank.transform.position = new Vector3(0, height, 0);
    }

    private void FixedUpdate()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit, Mathf.Infinity))
        {
            tank.transform.eulerAngles = new Vector3(hit.transform.rotation.eulerAngles.x, hit.transform.rotation.eulerAngles.y, hit.transform.rotation.eulerAngles.z);
            transform.position = new Vector3(transform.position.x, height + hit.point.y, transform.position.z);
        }
    }
}
