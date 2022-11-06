using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeFixOnStart : MonoBehaviour
{
    void Start()
    {
        //CollisionHandler.PlayFadeIn = false;
        TimeManager.StopTime = false;
        MobileController.Thrusting = false;
        MobileController.Left = false;
        MobileController.Right = false;

    }
}
