using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyerTrigg : MonoBehaviour
{
    [SerializeField] GameObject crashParticles;
    AudioSource audioSource;
    [SerializeField] AudioClip clip;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void OnTriggerEnter(Collider other)
    {
        if (!audioSource.isPlaying)
        {
            audioSource.PlayOneShot(clip);
        }
        Instantiate(crashParticles, other.transform.position, Quaternion.identity);
        Destroy(other.gameObject);
    }
}
