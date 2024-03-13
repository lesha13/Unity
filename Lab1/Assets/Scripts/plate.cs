using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class plate : MonoBehaviour
{
    [SerializeField] Vector3 rotate;
    [SerializeField] Vector3 point;
    [SerializeField] float up_y;
    [SerializeField] float degree;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.transform.RotateAround(point, rotate, degree);
        rb.transform.Translate(0, up_y, 0);
    }
}
