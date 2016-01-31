using UnityEngine;
using System.Collections;

public class Ground : MonoBehaviour {

    public Collider2D ground;
	// Use this for initialization
	void Start () {
        ground.GetComponent<Collider2D>();
	}
	
	// Update is called once per frame
	void Update () {

        ground.GetComponent<Collider2D>();
    }
}
