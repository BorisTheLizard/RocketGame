using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateObjTrigger : MonoBehaviour
{
    [SerializeField] GameObject[] objectsToActive;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "triggerrator")
        {
            foreach (GameObject toActive in objectsToActive)
            {
                toActive.SetActive(true);
            } 
        }
    }
}
