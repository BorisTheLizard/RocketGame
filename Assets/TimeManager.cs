using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager: MonoBehaviour
{
    public static bool StopTime = false;
    public static bool SlowTime = false;
    public static bool timeToSlowdown = false;
    private bool oneTick = false;
    [SerializeField] GameObject slowdownButton;
    [SerializeField] ParticleSystem stazisStop;
    AudioSource audioSource;
    [SerializeField] AudioClip stazisEnd;
    GameObject rocket;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        rocket = GameObject.Find("Rocket");
    }

    private void Update()
    {
        if (StopTime && !SlowTime)
        {
            Time.timeScale = 0;
        }
        else if(!StopTime && !SlowTime)
        {
            Time.timeScale = 1;
        }
        else if (SlowTime)
        {
            Time.timeScale = 0.5f;
        }
        else if(!SlowTime)
        {
            Time.timeScale = 1;
        }
        if (timeToSlowdown)
        {
            fixVelocity();
        }
    }
    void fixVelocity()
    {
        if (oneTick == false)
        {
             StartCoroutine(fixVelocityCorout());
        }
    }
    IEnumerator fixVelocityCorout()
    {
        oneTick = true;
        yield return new WaitForSeconds(0.01f);
        rocket.GetComponent<Rigidbody>().useGravity = true;
        rocket.GetComponent<Rigidbody>().drag = 0.5f;
        rocket.GetComponent<Rigidbody>().angularDrag = 0.05f;
        stazisStop.Play();
        audioSource.PlayOneShot(stazisEnd);
        slowdownButton.SetActive(false);
        MobileController.slowTimeBool = false;
        timeToSlowdown = false;
        oneTick = false;
    }
}
