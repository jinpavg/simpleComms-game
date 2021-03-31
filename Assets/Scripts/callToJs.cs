using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class callToJs : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void sendStringFromUnity(string str);

    void Start()
    {
        sendStringFromUnity("2");
    }

    void Update()
    {

    }

}
