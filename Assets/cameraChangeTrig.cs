using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class cameraChangeTrig : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera cameraToOff;
    [SerializeField] CinemachineVirtualCamera cameraToOnn;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "triggerrator")
        {
            cameraToOff.enabled = false;
            cameraToOnn.enabled = true;
        }
    }
}
