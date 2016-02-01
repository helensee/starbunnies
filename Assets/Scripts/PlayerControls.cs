using UnityEngine;
using System.Collections;

public class PlayerControls : MonoBehaviour {

    public float speed;
    public float jumpSpeed;
    public float jumpForce;
    public int score;
    public Transform target;
    public CharacterController controller;

    public bool isGrounded = true;
    private int jumpHeight = 400;

    private Rigidbody2D rb;
    private float move;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
		/*float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		rb.velocity = new Vector2 (speed * moveHorizontal, 0);*/
			
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(new Vector2(-10, 0), ForceMode2D.Force);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector2(10, 0), ForceMode2D.Force);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
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

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Star"))
        {
            if (other.offset == new Vector2(0, 0))
            {
                Destroy(other.gameObject);
                score++;
            }
            else
            {
                other.gameObject.GetComponent<Rigidbody2D>().isKinematic = false;
            }
        }
    }

}