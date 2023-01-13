

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] CarPrefabs;

    private float spawnLimitZLeft = -22;
    private float spawnLimitZRight = 7;
    private float spawnPosZ = 30;

    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomCar", startDelay, spawnInterval);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomCar ()
    {
        int CarIndex = Random.Range(0, CarPrefabs.Length);
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitZLeft, spawnLimitZRight),0,spawnPosZ );

        // instantiate ball at random spawn location
        Instantiate(CarPrefabs[CarIndex], spawnPos, CarPrefabs[CarIndex].transform.rotation);
    }

}
