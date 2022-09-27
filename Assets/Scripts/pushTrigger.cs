using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushTrigger : MonoBehaviour
{
    [SerializeField] float ForcePower = 10000f;
    [SerializeField] Vector3 direction;
    public void OnTriggerStay(Collider other)
    {
        
      if (other.tag == "Rocket")
        {
            other.attachedRigidbody.AddForce(direction * ForcePower * Time.deltaTime, ForceMode.Acceleration);
        }
    }
}
