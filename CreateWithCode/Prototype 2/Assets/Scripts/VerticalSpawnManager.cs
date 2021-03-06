using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalSpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs = new GameObject[3];
    public float spawnRangeX = 20, spawnPosZ = 20;
    public float startDelay = 2, spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX + 1), 0, spawnPosZ);

        Instantiate(animalPrefabs[animalIndex], spawnPosition, animalPrefabs[animalIndex].transform.rotation);
    }
}
