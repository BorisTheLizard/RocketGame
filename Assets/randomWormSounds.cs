using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomWormSounds : MonoBehaviour
{
    AudioSource audioSource;
    [SerializeField]AudioClip[] clips;
    private bool inUse = false;


    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void Update()
    {
        if (inUse == false)
        {
            StartCoroutine(SoundChoose());
        }
    }
    IEnumerator SoundChoose()
    {
        inUse = true;
        yield return new WaitForSeconds(Random.Range(1, 6));
        audioSource.clip = clips[Random.Range(0, clips.Length)];
        audioSource.Play();
        inUse = false;
    }
}
