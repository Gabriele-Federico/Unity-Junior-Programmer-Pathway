using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject[] cameras = new GameObject[2];
    private bool firstPerson = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            firstPerson = !firstPerson;
            ChangeCamera();
        }

    }

    private void ChangeCamera()
    {
        if(firstPerson)
        {
            cameras[0].SetActive(true);
            cameras[1].SetActive(false);
        }
        else
        {
            cameras[0].SetActive(false);
            cameras[1].SetActive(true);
        }
    }
}
