using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegularShooting : MonoBehaviour
{
    [SerializeField] GameObject FireBall;
    [SerializeField] Transform firePoint;
    [SerializeField] float shootingPower = 1000f;

    void shoot()
    {
        GameObject bolt = Instantiate(FireBall, firePoint.transform.position, Quaternion.identity);
        bolt.GetComponent<Rigidbody>().AddForce(-Vector3.right * shootingPower);
    }
}
