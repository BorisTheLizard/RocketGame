using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class signalTrigScr : MonoBehaviour
{
    AudioSource audioSource;
    [SerializeField] AudioClip clip;

    [SerializeField] GameObject text;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Rocket")
        {
            text.SetActive(true);
            if (!audioSource.isPlaying)
            {
                audioSource.PlayOneShot(clip);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        audioSource.Stop();
        text.SetActive(false);
    }
}
