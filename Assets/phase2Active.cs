using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class phase2Active : MonoBehaviour
{
    [SerializeField] GameObject phase1;
    [SerializeField] GameObject phase2;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "triggerrator")
        {
            phase1.SetActive(false);
            phase2.SetActive(!false);
            Destroy(this.gameObject);
        }
    }
}
