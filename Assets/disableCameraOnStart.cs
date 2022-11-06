using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class disableCameraOnStart : MonoBehaviour
{
    CinemachineVirtualCamera cam;

    private void Start()
    {
        cam = GetComponent<CinemachineVirtualCamera>();
        Invoke("camOff", 0.3f);
    }
    void camOff()
    {
        cam.enabled = false;
    }
}
