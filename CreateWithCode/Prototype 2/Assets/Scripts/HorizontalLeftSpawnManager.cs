using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//90
public class HorizontalLeftSpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs = new GameObject[3];
    private float spawnPosX = 20, spawnRangeZ = 20;
    private float startDelay = 1, spawnInterval = 2.75f;

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
        Vector3 spawnPosition = new Vector3(spawnPosX, 0, Random.Range(-3, spawnRangeZ + 1));

        Instantiate(animalPrefabs[animalIndex], spawnPosition, animalPrefabs[animalIndex].transform.rotation).transform.Rotate(0, 90, 0);
    }
}
