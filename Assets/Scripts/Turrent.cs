using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Turrent : MonoBehaviour
{
    public GameObject turrent;
    
    public float angle;
    private float rotateX;
    
    void OnRotate(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        rotateX = movementVector.x;
    }
    
    void Rotation()
    {
        if (rotateX >= 0.5)
        {
            turrent.transform.Rotate(Vector3.up * angle * Time.deltaTime);
        } 
        if (rotateX<= -0.5)
        {
            turrent.transform.Rotate(Vector3.down * angle * Time.deltaTime);
        }
    }

    private void Update()
    {
        Rotation();
    }
}
