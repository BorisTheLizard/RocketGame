using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectroStik : MonoBehaviour
{
    [SerializeField] ParticleSystem Electro;
    [SerializeField] float MinTimeToWait =3.5f;
    [SerializeField] float MaxTimeToWait = 4f;
    [SerializeField] Animator anim;
    [SerializeField] float animSpeed = 1f;
    AudioSource source;

    private void Start()
    {
        anim.speed = animSpeed;
        source = GetComponent<AudioSource>();
    }

    public void ShockingTime()
    {
        Electro.Play();
        StartCoroutine(Yo());
    }
    IEnumerator Yo()
    {
        source.Play();
        yield return new WaitForSeconds(Random.Range(MinTimeToWait,MaxTimeToWait));
        source.Stop();
        Electro.Stop();
    }
}
