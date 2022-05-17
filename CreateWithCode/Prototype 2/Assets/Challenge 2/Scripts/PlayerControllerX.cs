using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float timePassed = 2f;

    // Update is called once per frame
    void Update()
    {
        if(timePassed < 2)
            timePassed += Time.deltaTime;

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && timePassed >= 2)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timePassed = 0;
        }
    }
}
