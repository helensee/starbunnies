using UnityEngine;
using System.Collections;

public class ContinouslyMove : MonoBehaviour {


    public float speed;
    public float jumpSpeed;
    public float jumpForce;


    public Transform target;
    public CharacterController controller;
    public float offSetx;
    public float offSety;
    private float lockPos;

    public bool isGrounded = false;
    private int jumpHeight = 400;

    private Rigidbody2D rb;
    private float m_JumpForce = 400f;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }
        else
        {
            Vector2 movement = new Vector2(1, -speed);
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

        //rb.AddForce(new Vector2(0, 200), ForceMode2D.Force);

        //transform.position = new Vector2(target.transform.position.x + offSetx, lockPos + offSety);
        //rb.AddForce(transform.forward * jumpForce);

        /*
        Vector3 up = transform.TransformDirection(Vector3.up);
        Rigidbody test = new Rigidbody();
        test.AddForce(up * jumpForce, ForceMode.Impulse);
        test.velocity += up * jumpSpeed;
        */
        
    }

    void FixedUpdate()
    {
        isGrounded = Physics2D.Raycast(transform.position, -Vector2.up, 0.5f);
    }
}
