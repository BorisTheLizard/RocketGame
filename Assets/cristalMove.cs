using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cristalMove : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float speed = 0.1f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        rb.transform.Translate(0.01f, 0, 0 * speed * Time.deltaTime);
    }
}
