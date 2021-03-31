using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void sendStringFromUnity(string str);
    private string sendString;
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
    }

    void Randomizer()
    {
        int val = Random.Range(0, 100);

        sendString = val.ToString();
        Debug.Log("bang " + sendString);
        sendStringFromUnity(sendString);
    }
}
