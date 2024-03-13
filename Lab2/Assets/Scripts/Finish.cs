using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{ 

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Vector3 direction = transform.position - GameObject.FindGameObjectWithTag("Player").transform.position;

            other.GetComponent<PlayerMovement>().speed = 0;
            other.GetComponent<PlayerMovement>().jumpHeight = 0;

            Debug.Log("You won!");
        }
    }
}
