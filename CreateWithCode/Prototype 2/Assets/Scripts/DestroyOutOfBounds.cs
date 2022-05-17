using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float rightLeftBound = 25f;
    public float topBound = 30f;
    public float lowerBound = -10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
            Debug.Log("GameOver");
        }
        if (Mathf.Abs(transform.position.x) > rightLeftBound)
        {
            Destroy(gameObject);
            Debug.Log("GameOver");
        }
    }
}
