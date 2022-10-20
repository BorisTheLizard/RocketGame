using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endGameTrig : MonoBehaviour
{
    [SerializeField] GameObject rocket;
    [SerializeField] Transform tpPoint;
    [SerializeField] GameObject BlackScreen;
    [SerializeField] GameObject text;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "triggerrator")
        {
            rocket.transform.position = tpPoint.position;
            rocket.GetComponent<RocketMovement>().enabled = false;
            rocket.GetComponent<Rigidbody>().useGravity = false;
            BlackScreen.SetActive(true);
            Invoke("crocchy", 2);
        }
    }
    private void crocchy()
    {
        text.SetActive(true);
    }
}
