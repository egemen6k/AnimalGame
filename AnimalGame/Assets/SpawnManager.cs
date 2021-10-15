using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float _spawnRangeX,_spawnPosZ = 20f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Vector3 spawnPos = new Vector3(Random.Range(-_spawnRangeX, _spawnRangeX), 0, _spawnPosZ);
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Instantiate(animalPrefabs[animalIndex], spawnPos, 
                        animalPrefabs[animalIndex].transform.rotation);
        }
    }
}
