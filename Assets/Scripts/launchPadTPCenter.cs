using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class launchPadTPCenter : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] Transform point;

    private void OnTriggerEnter(Collider other)
    {
       if(other.tag == "Rocket")
        {
            other.attachedRigidbody.velocity = new Vector3(0,0,0);
            Player.transform.position = point.transform.position;
            Player.transform.rotation = Quaternion.Euler(0, 0, 0);
        } 
    }
}
