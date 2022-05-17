using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int lives = 3;
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseScore(int value)
    {
        score += value;
        Debug.Log("Score: " + score);
    }

    public void decreaseLives()
    {
        lives -= 1;
        if (lives <= 0)
            Debug.Log("GameOver");
        else
            Debug.Log("Lives: " + lives);
    }
}
