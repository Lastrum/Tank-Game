using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Fire : MonoBehaviour
{
    public GameObject turrent;

    private RaycastHit h;
    void OnFire(InputValue movementVale)
    {
        RaycastHit hit;
        if (Physics.Raycast(turrent.transform.position, transform.TransformDirection(Vector3.forward), out hit,
            Mathf.Infinity))
        {
            h = hit;
            Debug.DrawRay(turrent.transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);
            Debug.Log("[Fired] (Object Name: " + hit.collider.name + ") Object Tag: " + hit.collider.tag);
            
            if (hit.collider.CompareTag("Destructible"))
            {
                hit.transform.gameObject.SetActive(false);
                Debug.Log("Destroyed!");
            }
        }
    }

    private void FixedUpdate()
    {
        //Debug.DrawRay(turrent.transform.position, transform.TransformDirection(Vector3.forward) * h.distance, Color.red);
    }
}
