﻿using UnityEngine;
using System.Collections;

public class ContinouslyMove : MonoBehaviour {


    public float speed;
    public float jumpSpeed;
    public float jumpForce;
    
    public Transform target;
    public CharacterController controller;
    public float offSetx;
    public float offSety;

    public bool isGrounded = true;
    private int jumpHeight = 400;

    private Rigidbody2D rb;

    public Ground ground;
    public Transform top_left;
    public Transform bottom_right;
    public LayerMask ground_layers;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        ground = GetComponent<Ground>();
    }
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }
        else
        {
            Vector2 movement = new Vector2(2, -speed);
            transform.Translate(movement * Time.deltaTime);

        }
    }


    public void Jump()
    {
        if (!isGrounded)
        {
            return;
        }
        isGrounded = false;
        rb.AddForce(new Vector2(0, jumpHeight), ForceMode2D.Force);
    }

    void FixedUpdate()
    {
        //if (ground.gameObject.CompareTag("Grass"))
        //{
        //    isGrounded = true;
        //}
        isGrounded = Physics2D.Raycast(transform.position, -Vector2.up, 0.5f);
    }

    void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag ("Star")) {
			other.gameObject.GetComponent<Rigidbody2D>().isKinematic = false;
		}

	}
}
