using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressSoundMaker : MonoBehaviour
{
    AudioSource source;

    private void Start()
    {
        source = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "triggerrator")
        {
            return;
        }
        else
        {
            source.Play();
        }
    }
}
