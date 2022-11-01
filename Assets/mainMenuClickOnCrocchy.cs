using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainMenuClickOnCrocchy : MonoBehaviour
{
    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void clickOnCrocchy()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
        
    }
}
