using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controller : MonoBehaviour
{

    private float speed = 25f;
    private float turnSpeed = 30f;
    private float horizontaInput = 0, forwardInput = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Get player input
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
            horizontaInput = Input.GetAxis("Horizontal");
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
            forwardInput = Input.GetAxis("Vertical");

        //Moves the vehicle based on input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Rotates the vehicle based on input
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontaInput);
    }
}
