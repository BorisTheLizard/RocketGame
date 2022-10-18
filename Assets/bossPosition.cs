using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossPosition : MonoBehaviour
{
    [SerializeField] Transform rocket;
    [SerializeField] float moveSpeed = 1000f;
    [SerializeField] float followingDist = 10f;

    private void FixedUpdate()
    {
            transform.position = new Vector3(transform.position.x, rocket.transform.position.y, transform.position.z);
    }
}
