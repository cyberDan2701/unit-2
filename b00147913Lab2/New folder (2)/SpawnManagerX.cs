using System.Collections;
using System.Collections.Generic;
using NUnit.Framework.Internal;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] BallPrefabs;
    
    
    private float spawnRangeLeft = -36 ;
    private float spawnRangeRight =  9 ;
    private float spawnPosY = 30;
    private float startDelay = 1.0f;
    

    // Start is called before the first frame update
    void Start()
    {   
        // making at variable and giving its value a random range of between 2 and 6 
        float spawnInterval = Random.Range(2, 6);
        InvokeRepeating("SpawnRandomBall", startDelay,spawnInterval);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnRangeLeft, spawnRangeRight), spawnPosY, 0);
        int ballIndex = Random.Range(0, BallPrefabs.Length);
        // instantiate ball at random spawn location
        Instantiate(BallPrefabs[ballIndex], spawnPos, BallPrefabs[ballIndex].transform.rotation);
    }

}

