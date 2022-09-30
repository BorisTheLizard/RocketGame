using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class destroyerTrigg : MonoBehaviour
{
    [SerializeField] GameObject crashParticles;
    AudioSource audioSource;
    [SerializeField] AudioClip clip;
    CinemachineImpulseSource impulse;


    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        impulse = transform.GetComponent<CinemachineImpulseSource>();
    }
    public void OnTriggerEnter(Collider other)
    {
        Handheld.Vibrate();
        impulse.GenerateImpulse();
        if (!audioSource.isPlaying)
        {
            audioSource.PlayOneShot(clip);
        }
        Instantiate(crashParticles, other.transform.position, Quaternion.identity);
        Destroy(other.gameObject);
    }
}
