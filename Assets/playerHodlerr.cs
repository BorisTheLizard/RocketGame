using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHodlerr : MonoBehaviour
{
    [SerializeField] GameObject rocket;

    private void FixedUpdate()
    {
        rocket.transform.position = transform.position;
    }
}
