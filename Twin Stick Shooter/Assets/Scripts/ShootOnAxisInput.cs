using UnityEngine;
using System.Collections;

public class ShootOnAxisInput : MonoBehaviour {

    public GameObject bullet;

    public string horizontalAxis = "Horizontal";
    public string verticalAxis = "Vertical";

    public float shootDelay = 15f;

    private bool canShoot = true;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 shootDirection = Vector3.right * Input.GetAxis(horizontalAxis) + Vector3.forward * Input.GetAxis(verticalAxis);
        {
            transform.rotation = Quaternion.LookRotation(shootDirection, Vector3.up);
            Instantiate(bullet, transform.position, transform.rotation);

            canShoot = false;
            Invoke("ResetShot", shootDelay);
        }

    }

    void resetShot()
    {
        canShoot = true;
    }
}
