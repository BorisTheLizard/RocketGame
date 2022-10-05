using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CristalTP : MonoBehaviour
{
    [SerializeField] Transform TpPoint;
    [SerializeField] Transform RocketTpPoint;
    AudioSource audioSource;
    [SerializeField] AudioClip clip;
    [SerializeField] ParticleSystem tpParts;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (!audioSource.isPlaying)
        {
             audioSource.PlayOneShot(clip);
        }
        tpParts.Play();

        if(other.tag == "Rocket")
        {
            other.transform.position = RocketTpPoint.position;
            other.transform.rotation = Quaternion.Euler(0, 0, 0);
            other.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        }
        else if(other.tag == "Crystals")
        {
            other.transform.position = TpPoint.position;
        }
    }
}
