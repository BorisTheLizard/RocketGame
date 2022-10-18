using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookAtCamera : MonoBehaviour
{
    [SerializeField] Transform cam;
    [SerializeField] Vector3 direction;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.LookAt(cam, direction);
    }
}
