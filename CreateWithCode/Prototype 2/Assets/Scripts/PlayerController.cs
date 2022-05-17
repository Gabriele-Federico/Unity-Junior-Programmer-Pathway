using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public GameObject projectilePrefab;
    private float horizontalInput, verticalInput;
    private float speed = 10f;
    private float xRange = 15f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);

        if (transform.position.x < -xRange) transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        if (transform.position.x > xRange) transform.position = new Vector3(xRange, transform.position.y, transform.position.z);


        if (transform.position.z < -2) transform.position = new Vector3(transform.position.x, transform.position.y, -2);
        if (transform.position.z > 17) transform.position = new Vector3(transform.position.x, transform.position.y, 17);

        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
    }
}
