using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void sendStringFromUnity(string str);

    [DllImport("__Internal")]
    private static extern void pickSampleFromUnity(int x);    

    private string sendString;
    private float spawnRangeX = 20;
    private float spawnRangeZ = 20;
    public GameObject targetBox;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Randomizer();
        SpawnBox();
        // Destroy the target you hit
        Destroy(other.gameObject);
    }

    void Randomizer()
    {
        int val = Random.Range(0, 100);
        int sampleIndex = Random.Range(0, 3);

        sendString = val.ToString();
        Debug.Log("bang " + sendString + sampleIndex);
        sendStringFromUnity(sendString);
        pickSampleFromUnity(sampleIndex);
    }
    void SpawnBox()
    {
        // randomly generate spawn position
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 1.5f, Random.Range(-spawnRangeZ, spawnRangeZ));
        Debug.Log("bang2");
        Instantiate(targetBox, spawnPos, targetBox.transform.rotation);
    }
}
