using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnRandomBall", startDelay);
    }

    void SpawnRandomBall ()
    {
        spawnInterval = Random.Range(3,5);
        Invoke("SpawnRandomBall", spawnInterval);

        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        int randomNumber = Random.Range(0, 3);
        Instantiate(ballPrefabs[randomNumber], spawnPos, ballPrefabs[randomNumber].transform.rotation);
    }
}
