using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timelineActiveTrig : MonoBehaviour
{
    [SerializeField] GameObject timeline;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "triggerrator")
        {
            timeline.SetActive(true);
        }
    }
}
