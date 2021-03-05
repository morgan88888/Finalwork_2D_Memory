﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk2f : MonoBehaviour
{ 
public Rigidbody2D Yu;
public float speed;
public bool walk;
Vector3 movement;
Animator animator;

void Start()
{
    animator = GetComponent<Animator>();
}
void Update()
{
    Movement();

    movement = new Vector3(Input.GetAxisRaw("Horizontal") * Time.deltaTime * speed, Input.GetAxisRaw("Vertical") * Time.deltaTime * speed, 0);

    transform.Translate(movement);

    if (movement != Vector3.zero)
    {
        animator.SetBool("walk", true);
    }
    else
    {
        animator.SetBool("walk", false);
    }
}


void Movement()
{
    float horizontalmove = Input.GetAxis("Horizontal");
    float facedircetion = Input.GetAxisRaw("Horizontal");


    if (horizontalmove != 0)
    {
        Yu.velocity = new Vector2(horizontalmove * speed, Yu.velocity.y);

    }


    if (facedircetion != 0)
    {
        transform.localScale = new Vector3((float)-1.381793, (float)1.437913, 1);

        if (facedircetion != 1)
        {
            transform.localScale = new Vector3((float)1.381793, (float)1.437913, 1);
        }

    }



}
}
