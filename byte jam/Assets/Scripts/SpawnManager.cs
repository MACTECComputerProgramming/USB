using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] fruitPrefabs;

    private float spawnLimitXLeft = -1;
    private float spawnLimitXRight = 1;
    private float spawnPosY = 3;

    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;
    public float thrust = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomFruit", startDelay, spawnInterval);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomFruit()
    {
        // Generate random ball index and random spawn position
        int num = Random.Range(0, 3);
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, -3);

        // instantiate ball at random spawn location
        Instantiate(fruitPrefabs[num], spawnPos, fruitPrefabs[num].transform.rotation);
    }

}
