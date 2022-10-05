using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnOnTrigger : MonoBehaviour
{
    [SerializeField] GameObject[] turrels;

    private void OnTriggerEnter(Collider other)
    {
        foreach (GameObject gun in turrels)
        {
            gun.SetActive(true);
        }
    }
}
