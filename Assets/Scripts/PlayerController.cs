using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public GameObject player;
    public GameObject turrent;
    
    public float speed;
    public float angle;
    
    private float movementX;
    private float movementY;

    private float rotateX;
    private void Awake()
    {
        player = gameObject;
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;
    }

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
    
    void Movement()
    {
        if (movementY >= 0.5)
        {
            player.transform.position += Vector3.forward * speed * Time.deltaTime;
        } 
        if (movementY <= -0.5)
        {
            player.transform.position += Vector3.back * speed * Time.deltaTime;
        }
        if (movementX >= 0.5)
        {
            player.transform.position += Vector3.right * speed * Time.deltaTime;
        } 
        if (movementX <= -0.5)
        {
            player.transform.position += Vector3.left * speed * Time.deltaTime;
        }
    }
    
    private void Update()
    {
        Movement();
        Rotation();
    }
}
