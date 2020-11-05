﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] fruitPrefabs;

    private float spawnLimitXLeft = -1.5f;
    private float spawnLimitXRight = 1.5f;
    private float spawnPosY = -3;

    public float thrust = 4.0f;
    
    void Start()
    {
        StartCoroutine("SpawnRandomFruit");
    }

    // Spawn random ball at random x position at top of play area
    public IEnumerator SpawnRandomFruit()
    {
        // Generate random ball index and random spawn position
        int num = Random.Range(0, fruitPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, -3);

        // instantiate ball at random spawn location
        Instantiate(fruitPrefabs[num], spawnPos, fruitPrefabs[num].transform.rotation);
        float time = Random.Range(.5f,3f);
        yield return new WaitForSeconds(time);
        StartCoroutine("SpawnRandomFruit");
    }

}
