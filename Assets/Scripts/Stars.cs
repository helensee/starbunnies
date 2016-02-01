using UnityEngine;
using System.Collections;

public class Stars : MonoBehaviour {

	private Rigidbody2D rb;

    public GameObject shatterParticle;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}

    void Update()
    {

       //
    }
	/*void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Star")) {
			rb.isKinematic = false;
		}
	}*/

    void OnTriggerEnter2D(Collider2D meh)
    {

        Instantiate(shatterParticle, rb.transform.position, rb.transform.rotation);
    }

    void OnTriggerExist2D(Collider2D meh)
    {
        Destroy(rb);
    }
}
