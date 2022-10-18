using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cristalMove : MonoBehaviour
{
    [SerializeField] float speed = 0.1f;
    Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        rb.transform.Translate(Vector3.right * Time.deltaTime * speed);
    }
}
