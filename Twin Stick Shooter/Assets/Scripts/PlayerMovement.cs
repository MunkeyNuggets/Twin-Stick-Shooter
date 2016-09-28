using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public string horizontalAxis = "Horizontal";
    public string verticalAxis = "Vertical";

    public float speed = 1.0f;
    

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += (Vector3.right * Input.GetAxis(horizontalAxis) + Vector3.forward * Input.GetAxis(verticalAxis))* speed* Time.deltaTime;

    }
}
