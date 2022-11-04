using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateObjTrigger : MonoBehaviour
{
    [SerializeField] GameObject[] objectsToActive;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Rocket")
        {
            foreach (GameObject toActive in objectsToActive)
            {
                Debug.Log("ACtivating");
                toActive.SetActive(true);
            } 
        }
    }
}
