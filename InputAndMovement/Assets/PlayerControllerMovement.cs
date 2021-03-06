﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerMovement : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rb2d;
    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        
        Vector2 movement = new Vector2(x, y) * speed * Time.deltaTime;

        rb2d.velocity = movement;
    }
}
