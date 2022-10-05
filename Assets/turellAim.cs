using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turellAim : MonoBehaviour
{
    [Header("Position - Rotation")]
    [SerializeField] Transform BarrelTransform;
    [SerializeField] Transform shootingPoint;
    [SerializeField] Transform Rocket;


    [Header("Shooting Vars")]
    [SerializeField] GameObject Projectiles;
    [SerializeField] float ShootingPower = 200f;
    bool ShootingTime = false;
    [SerializeField] float timeToWait = 2f;

    [Header("Agro Slow Down")]
    [SerializeField] float DIstance = 10f;

    [Header("Audio")]
    AudioSource audioSource;
    //[SerializeField] AudioClip clip;
    [SerializeField] AudioClip shooting;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void FixedUpdate()
    {
        
        float dist = Vector3.Distance(Rocket.position, transform.position);

        if (dist < DIstance)
        {
            BarrelTransform.transform.LookAt(Rocket);
            if (!ShootingTime)
            {
                StartCoroutine(shoot());
            }
        }
    }
    IEnumerator shoot()
    {
        ShootingTime = true;
        //audioSource.PlayOneShot(clip);
        yield return new WaitForSeconds(timeToWait);
        shootFunk();
        yield return new WaitForSeconds(0.3f);
        shootFunk();
        yield return new WaitForSeconds(0.3f);
        shootFunk();
        ShootingTime = false;
    } 

    private void shootFunk()
    {
        audioSource.PlayOneShot(shooting);
        GameObject bullets = Instantiate(Projectiles, shootingPoint.position, Quaternion.identity);
        bullets.GetComponent<Rigidbody>().AddRelativeForce(shootingPoint.up * ShootingPower);
    }
}
