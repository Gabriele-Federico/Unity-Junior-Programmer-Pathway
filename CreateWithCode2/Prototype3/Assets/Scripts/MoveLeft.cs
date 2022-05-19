using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private static float speed = 30f;
    private PlayerController playerController;
    private float leftBound = -15;

    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!playerController.gameOver)
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
            Destroy(gameObject);
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            if (speed != 60)
            {
                speed = 60;
                playerController.gameObject.GetComponent<Animator>().SetInteger("Speed_f", 4);
            }

        }
        if (Input.GetKeyUp(KeyCode.LeftShift)) 
            if (speed != 30)
            {
                speed = 30;
                playerController.gameObject.GetComponent<Animator>().SetInteger("Speed_f", 2);
            }


           
    }

    private void IncreaseSpeed(float increment)
    {
        
    }
}
