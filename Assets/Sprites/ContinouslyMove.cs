using UnityEngine;
using System.Collections;

public class ContinouslyMove : MonoBehaviour {


    public float speed;
    public float jumpSpeed;
    public float jumpForce;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 movement = new Vector2(1, -speed);
        transform.Translate(movement * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
	}


    public void Jump()
    {
        Vector3 up = transform.TransformDirection(Vector3.up);
        Rigidbody test = new Rigidbody();
        test.AddForce(up * jumpForce, ForceMode.Impulse);
        test.velocity += up * jumpSpeed;

    }
}
