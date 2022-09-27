using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaShooting : MonoBehaviour
{
    public Vector3[] point;
    [SerializeField] float speed = 100f;
    [SerializeField] GameObject fireBolt;
    float timMe;
    [SerializeField] float maxTime = 1f;

    private void Update()
    {
        if (Time.time > timMe)
        {
            timMe = Time.time + maxTime;
            Shoot();
        }
    }

    public void Shoot()
    {
        Vector3 spawnPosition = point[Random.Range(0, point.Length)];
        Quaternion spawnRotation = Quaternion.identity;
        GameObject HotShots = Instantiate(fireBolt, spawnPosition, spawnRotation);
        HotShots.GetComponent<Rigidbody>().AddForce(Vector3.up * speed,ForceMode.Force);
    }

}
