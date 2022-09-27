using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;

public class pointTransform : MonoBehaviour
{
    [SerializeField] Transform Rocket;
    [SerializeField] float AimDistance = 30;
    [SerializeField] float AimRange = 31;
    [SerializeField] MultiAimConstraint HeadWeight;
    [SerializeField] string State = "IDLE";
    [SerializeField] Transform flower;

    private void Update()
    {
        float distance = Vector3.Distance(flower.transform.position, Rocket.position);

        if (State == "IDLE")
        {
            transform.position = flower.transform.position;
            HeadWeight.weight = 0;

            if (distance < AimDistance)
            {
                State = "AIM";
            }
        }
        else if (State == "AIM")
        {

            transform.position = Rocket.transform.position;
            HeadWeight.weight = 1f;

            if (distance > AimRange)
            {
                State = "IDLE";
            }

        }

    }
}
