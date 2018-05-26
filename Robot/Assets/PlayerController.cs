using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public KeyCode left;
    public KeyCode right;
    public int speed;
    public int angspeed;
    Rigidbody rb;
    private Vector3 direccion;
    private Vector3 direccionAngular;
    public Vector3 headPosition;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        direccion = new Vector3(1, 0, 0);
        direccionAngular = new Vector3(1, 2, 0);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(right)) {
            //rb.AddForce(direccion * speed);
            rb.AddForceAtPosition(direccionAngular * angspeed * -1, headPosition);
        }

        if (Input.GetKey(left))
        {
            //rb.AddForce(direccion * speed * -1);
            rb.AddForceAtPosition(direccionAngular * angspeed, headPosition);
        }
    }
}
