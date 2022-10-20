using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class cameraShakeTrig : MonoBehaviour
{
    CinemachineImpulseSource impulse;

    private void Start()
    {
        impulse = GetComponent<CinemachineImpulseSource>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "triggerrator")
        {
            impulse.GenerateImpulse();
        }
    }
}
