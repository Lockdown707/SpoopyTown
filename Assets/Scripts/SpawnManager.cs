using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] alienPrefabs;
    public float spawnRangeX = 10;
    public float spawnPosZ = 10;
    public float spawnRangeY = 10;
    public float startDelay = 2;
    public float spawnInterval = 3.5f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAlien", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }
    // Method Spawning Aliens
    void SpawnRandomAlien()
    {
        int alienIndex = Random.Range(0, alienPrefabs.Length);
        //Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Vector3 spawnPos = transform.position;

        Instantiate(alienPrefabs[alienIndex], spawnPos, transform.rotation);
    }
}
