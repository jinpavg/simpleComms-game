using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject targetBox;
    private float spawnRangeX = 20;
    private float spawnRangeZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        // spawns box after a set delay and at a given interval
        InvokeRepeating("SpawnBox", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnBox()
    {
        // randomly generate spawn position
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 1.5f, Random.Range(-spawnRangeZ, spawnRangeZ));

        Instantiate(targetBox, spawnPos, targetBox.transform.rotation);
    }
}
