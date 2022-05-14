using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject[] cameras;
    private bool firstPerson = false, firstPerson2 = false;

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
            ChangePlayer1Camera();
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            firstPerson2 = !firstPerson2;
            ChangePlayer2Camera();
        }


    }

    private void ChangePlayer1Camera()
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

    private void ChangePlayer2Camera()
    {
        if (firstPerson2)
        {
            cameras[2].SetActive(true);
            cameras[3].SetActive(false);
        }
        else
        {
            cameras[2].SetActive(false);
            cameras[3].SetActive(true);
        }
    }
}
