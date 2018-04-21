using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuerzasAngulares : MonoBehaviour {

    public KeyCode left;
    public KeyCode right;
    public int angspeed;
    Rigidbody rb;
    private Vector3 direccion;
    public Vector3 headPosition;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        direccion = new Vector3(1, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(right))
        {
            rb.AddForceAtPosition(direccion * angspeed *-1 , headPosition);
        }

        if (Input.GetKey(left))
        {
            rb.AddForceAtPosition(direccion * angspeed, headPosition);
        }
    }
}