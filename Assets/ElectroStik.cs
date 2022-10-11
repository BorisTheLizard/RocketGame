using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectroStik : MonoBehaviour
{
    [SerializeField] ParticleSystem Electro;
    [SerializeField] float timeToWait =3f;
    [SerializeField] Animator anim;
    [SerializeField] float animSpeed = 1f;

    private void Start()
    {
        anim.speed = animSpeed;
    }

    public void ShockingTime()
    {
        Electro.Play();
        StartCoroutine(Yo());
    }
    IEnumerator Yo()
    {
        yield return new WaitForSeconds(timeToWait);
        Electro.Stop();
    }
}
