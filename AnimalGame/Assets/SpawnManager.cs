using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float _spawnRangeX = 20f; 
    private float _spawnPosZ = 20f;
    private float _startDelay = 2f;
    private float _spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", _startDelay, _spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void SpawnRandomAnimal()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-_spawnRangeX, _spawnRangeX), 0, _spawnPosZ);
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPos,
                    animalPrefabs[animalIndex].transform.rotation);
    }
}
