using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class RocketMovement : MonoBehaviour
{
    [SerializeField] float mainThrust = 100;
    [SerializeField] float rotation = 100;
    [SerializeField] AudioClip mainEngine;

    [SerializeField] ParticleSystem Flame;
    [SerializeField] ParticleSystem RightThrust;
    [SerializeField] ParticleSystem LeftThrust;
    [SerializeField] GameObject spinner;

    [SerializeField] CapsuleCollider col;
    [SerializeField] LayerMask WalkingGround;

    Rigidbody rb;
    AudioSource audioSource;
    bool isAlive;

    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
        //float Zposition = transform.position.z;
    }

    

    void FixedUpdate()
    {
        ProcessThrust();
        ProcessRotation();
        float vectorZ = transform.eulerAngles.z;
        if(transform.rotation.x != 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, vectorZ);
        }
    }

    public void ProcessThrust()
    {

        if (Input.GetKey(KeyCode.Space) || MobileController.Thrusting == true)

        {
            Thrusting();
        }
        else
        {
            audioSource.Stop();
            spinner.transform.Rotate(0, 0, 0);
        }

    }

    private void Thrusting()
    {
        rb.AddRelativeForce(Vector3.up * mainThrust * Time.deltaTime);
        //transform.position = new Vector3(0, 0, Zposition);

        if (!audioSource.isPlaying)
        {
            audioSource.PlayOneShot(mainEngine);
        }
        if (!Flame.isPlaying)
        {
            Flame.Play();
        }
        spinner.transform.Rotate(0, 0, 5);
    }

    void ProcessRotation()
    {
        if (Input.GetKey(KeyCode.A) && !IsGrouded() || MobileController.Left && !IsGrouded())
        {
            ApplyRotation(rotation);
            if (!LeftThrust.isPlaying)
            {
                LeftThrust.Play();
            }
        }

        else if (Input.GetKey(KeyCode.D) && !IsGrouded() || MobileController.Right && !IsGrouded())
        {
            ApplyRotation(-rotation);
            if (!RightThrust.isPlaying)
            {
                RightThrust.Play();
            }
        }
        else
        {
            LeftThrust.Stop();
            RightThrust.Stop();
        }
    }

    public void ApplyRotation(float rotationThisFrame)
    {
        rb.freezeRotation = true;
        transform.Rotate(Vector3.forward * rotationThisFrame * Time.deltaTime);
        rb.freezeRotation = false;
    }
    private bool IsGrouded()
    {
        return Physics.CheckCapsule(col.bounds.center, new Vector3(col.bounds.center.x,
        col.bounds.min.y, col.bounds.center.z), col.radius * .9f, WalkingGround);
    }
}
