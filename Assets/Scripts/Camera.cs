using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {

    public GameObject player;

    public int depthOffset = 0;
    public int verticalOffset = 0;

    // Use this for initialization
    void Start () {
        player = GetComponent<GameObject>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector2(player.transform.position.x, 0);

	}
}
