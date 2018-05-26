using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MovLateral : MonoBehaviour {
    Rigidbody rb;
    private Vector3 direccion;
    public KeyCode left;
    public KeyCode right;
    public int speed;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        direccion = new Vector3(1, 0, 0);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(right))
        {
            rb.AddForce(direccion * speed);
        }

        if (Input.GetKey(left))
        {
            rb.AddForce(direccion * speed * -1);
        }
    }
}
