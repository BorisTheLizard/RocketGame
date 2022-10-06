using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTelepot : MonoBehaviour
{
    [SerializeField] GameObject Rocket;
    [SerializeField] Transform TPpoint;

    [SerializeField] ParticleSystem TPparts;
    [SerializeField] ParticleSystem TPpointParts;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Rocket")
        {
            Rocket.transform.position = TPpoint.position;
            other.transform.rotation = Quaternion.Euler(0, 0, 0);
            other.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            TPparts.Play();
            TPpointParts.Play();
        }
    }
}
