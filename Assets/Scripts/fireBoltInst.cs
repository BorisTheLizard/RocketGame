using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireBoltInst : MonoBehaviour
{
    [SerializeField] Transform point;
    [SerializeField] GameObject fireBolt;
    [SerializeField] float power = 100f;

    public void Shoot()
    {
        GameObject Bolt = Instantiate(fireBolt, point.position, Quaternion.identity);
        Bolt.GetComponent<Rigidbody>().AddForce(point.forward * power);
    }
}
