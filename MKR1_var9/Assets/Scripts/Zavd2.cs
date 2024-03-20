    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zavd2 : MonoBehaviour
{
    void Start()
    {
        Vector3 vec1 = new Vector3(4.0f, 5.0f, 7.0f);
        Vector3 vec2 = new Vector3(7.0f, 0.0f, 1.0f);

        Vector3 vec = vec1 + vec2;
        float length = vec.magnitude;
        
        Debug.Log("Zavd2");
        Debug.Log(vec);
        Debug.Log(length);
    }
}
