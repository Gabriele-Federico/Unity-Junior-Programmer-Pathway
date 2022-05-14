using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float speed = 25f;
    private float turnSpeed = 30f;
    private float horizontaInput, forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Get player input
        horizontaInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxisRaw("Vertical");

        //Moves the vehicle based on input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Rotates the vehicle based on input
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontaInput);
    }
}
