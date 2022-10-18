using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ExplosionCircle : MonoBehaviour
{
    [SerializeField] GameObject explosionParticles;
    [SerializeField] GameObject emptyEuler;
    CinemachineImpulseSource impulse;

    private void Start()
    {
        impulse = GetComponent<CinemachineImpulseSource>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(explosionParticles, gameObject.transform.position, Quaternion.identity);
        Instantiate(emptyEuler, gameObject.transform.position, Quaternion.identity);
        impulse.GenerateImpulse();
        Destroy(this.gameObject);
    }
}
