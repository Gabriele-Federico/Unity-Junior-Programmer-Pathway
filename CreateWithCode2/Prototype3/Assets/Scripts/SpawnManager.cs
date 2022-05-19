using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] obstaclePrefabs;
    private Vector3 spawnPosition = new Vector3(25, 0, 0);
    public float startDelay = 2f;
    public float repeatRate = 2f;
    private PlayerController playerController;
    private int prefabIndex;

    // Start is called before the first frame update
    void Start()
    {
        prefabIndex = Random.Range(0, obstaclePrefabs.Length);
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnObstacle()
    {
        prefabIndex = Random.Range(0, obstaclePrefabs.Length);
        if(!playerController.gameOver)
            Instantiate(obstaclePrefabs[prefabIndex], spawnPosition, obstaclePrefabs[prefabIndex].transform.rotation);
    }
}
