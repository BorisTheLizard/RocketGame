using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOController : MonoBehaviour
{
    [Header("Position - Rotation")]
    [SerializeField] Transform shootingPoint;
    [SerializeField] Transform Rocket;


    [Header("Shooting Vars")]
    [SerializeField] GameObject Projectiles;
    [SerializeField] float ShootingPower = 200f;
    bool ShootingTime = false;
    [SerializeField] float timeToWait = 2f;

    [Header("Agro Slow Down")]
    [SerializeField] float DIstance = 10f;
    public Animator anim;
    public float animSpeedToretur = 1f;

    [Header("Audio")]
    AudioSource audioSource;
    [SerializeField] AudioClip clip;
    [SerializeField] AudioClip shooting;
    [SerializeField] Light agroLight;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void FixedUpdate()
    {
        shootingPoint.transform.LookAt(Rocket);
        float dist = Vector3.Distance(Rocket.position, transform.position);
        
        
        if(dist < DIstance)
        {
            anim.speed = 0.2f;
                if (!ShootingTime)
                {
                    StartCoroutine(shoot());
                }
        }
        else
        {
            anim.speed = animSpeedToretur;
        }
    }
    IEnumerator shoot()
    {
        ShootingTime = true;
        agroLight.enabled = true;
        audioSource.PlayOneShot(clip);
        yield return new WaitForSeconds(timeToWait);
        audioSource.PlayOneShot(shooting);
        GameObject bullets = Instantiate(Projectiles, shootingPoint.position, Quaternion.identity);
        bullets.GetComponent<Rigidbody>().AddRelativeForce(shootingPoint.forward * ShootingPower);
        agroLight.enabled = false;
        ShootingTime = false;
    }
}
