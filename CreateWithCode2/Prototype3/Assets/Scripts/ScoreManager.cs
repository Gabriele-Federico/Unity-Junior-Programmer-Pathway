using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    private PlayerController playerController;
    private int score;
    public float startDelay = .1f, repeatRate = .5f;

    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("IncreaseScore", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void IncreaseScore()
    {
        if (!playerController.gameOver)
        {
            if (playerController.speedDoubled)
                score += 4;
            else
                score += 2;
            Debug.Log(score);
        }
    }
}
