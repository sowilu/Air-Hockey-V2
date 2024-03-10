using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    public float speed = 10;
    
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        //convert ui mouse coordinates to world coordinates
        var worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        worldPos.z = 0;
        
        //move the player towards the mouse according to given speed
        var target = Vector3.MoveTowards(transform.position, worldPos, speed * Time.fixedDeltaTime);
        
        var targetViewportPos = Camera.main.WorldToViewportPoint(target);
        if (targetViewportPos.x < 0.5f)
        {
            rb.velocity = Vector2.zero;
        }
        else
        {
            rb.MovePosition(target);
        }
    }
}
