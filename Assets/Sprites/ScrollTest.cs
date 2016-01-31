using UnityEngine;
using System.Collections;

public class ScrollTest : MonoBehaviour {
    public float speed = 0;
    public static ScrollTest current;
    // Use this for initialization
    float pos = 0;
	void Start () {
        current = this;
	}
	
	// Update is called once per frame
	void Update () {
        pos += speed;
        if(pos > 1.0f)
        {
            pos -= 1.0f;
        }

        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(pos, 0);
	}
}
