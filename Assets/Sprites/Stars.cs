using UnityEngine;
using System.Collections;

public class Stars : MonoBehaviour {

	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}

	/*void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Star")) {
			rb.isKinematic = false;
		}
	}*/
}
