using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zavd3Dart : MonoBehaviour
{
  public float moveSpeed = 50f;
  public float curveAmount = 10f;
  private bool isMoving = false;

  void Update()
  {
    if (Input.GetKeyDown(KeyCode.Space) && !isMoving)
    {
      isMoving = true;
    }

    if (isMoving)
    {
      ThrowDart();
    }
  }

    void ThrowDart()
    {
    transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
    transform.position -= new Vector3(curveAmount * Time.deltaTime * moveSpeed, curveAmount * Time.deltaTime * moveSpeed, 0f);
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Board"))
        {   
            isMoving = false;
            Debug.Log("Zavd3");
            Debug.Log("Success!");
        }
    }
}