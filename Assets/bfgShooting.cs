using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bfgShooting : MonoBehaviour
{
    [SerializeField] Transform shootingPoint;
    [SerializeField] GameObject proj;
    [SerializeField] float PushPower = 100f;
    [SerializeField] float TimeTOWait = 2f;

    bool WaitToshoot = false;



    // Update is called once per frame
    void FixedUpdate()
    {
        if (WaitToshoot == false)
        {
            StartCoroutine(shoot());
        }
    }
    IEnumerator shoot()
    {
        WaitToshoot = true;
        yield return new WaitForSeconds(TimeTOWait);
        GameObject ball = Instantiate(proj, shootingPoint.transform.position, Quaternion.identity);
        ball.GetComponent<Rigidbody>().AddForce(-Vector3.right * PushPower * Time.deltaTime);
        WaitToshoot = false;
    }
}
