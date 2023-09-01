using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{   
    public GameObject[] animalPrefabs;
    private readonly float spawnRangeX = 20;
    private readonly float spawnRangeZ = 30;
    private readonly float spawnPosZ = 20;
    private readonly float initialDelay = 2;
    private readonly float frequency = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimalFromTop", initialDelay, frequency);
        InvokeRepeating("SpawnRandomAnimalFromLeft", initialDelay, frequency);
        InvokeRepeating("SpawnRandomAnimalFromRight", initialDelay, frequency);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimalFromTop()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        GameObject animal = animalPrefabs[animalIndex];
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Quaternion rotation = animal.transform.rotation;
        Instantiate(animal, spawnPos, rotation);
    }

    void SpawnRandomAnimalFromLeft()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        GameObject animal = animalPrefabs[animalIndex];
        Vector3 spawnPos = new Vector3(-spawnRangeX, 0, Random.Range(0, spawnRangeZ));
        Quaternion rotation = Quaternion.Euler(new Vector3(0, 90, 0));
        Instantiate(animal, spawnPos, rotation);
    }

    void SpawnRandomAnimalFromRight()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        GameObject animal = animalPrefabs[animalIndex];
        Vector3 spawnPos = new Vector3(spawnRangeX, 0, Random.Range(0, spawnRangeZ));
        Quaternion rotation = Quaternion.Euler(new Vector3(0, 270, 0));
        Instantiate(animal, spawnPos, rotation);
    }



}
