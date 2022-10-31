using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormTriggerScr : MonoBehaviour
{
    [SerializeField] Animator anim;
    AudioSource audioSource;
    [SerializeField] AudioClip[] clips;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "triggerrator")
        {
            audioSource.clip = clips[Random.Range(0, clips.Length)];
            audioSource.Play();
            anim.SetTrigger("attack");
        }
    }
}
