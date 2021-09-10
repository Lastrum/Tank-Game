using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public GameObject player;
    public float speed;
    
    private float movementX;
    private float movementY;
    
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
    void Movement()
    {
        if (movementY >= 0.5)
        {
            //Foward
            player.transform.position += transform.forward * speed * Time.deltaTime;
        } 
        if (movementY <= -0.5)
        {
            //Back
            player.transform.position += -transform.forward * speed * Time.deltaTime;
        }
        if (movementX >= 0.5)
        {
            //Right
            player.transform.position += transform.right * speed * Time.deltaTime;
        } 
        if (movementX <= -0.5)
        {
            //Left
            player.transform.position += -transform.right * speed * Time.deltaTime;
        }
    }
    
    private void Update()
    {
        Movement();
    }
}
