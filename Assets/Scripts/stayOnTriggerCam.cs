using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class stayOnTriggerCam : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera cameraToActive;
    [SerializeField] CinemachineVirtualCamera cameraToOff;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Rocket")
        {
            cameraToActive.Priority = 100;
            cameraToOff.Priority = 10;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        cameraToActive.Priority = 10;
        cameraToOff.Priority = 100;
    }
}
