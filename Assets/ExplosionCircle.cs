using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionCircle : MonoBehaviour
{
    [SerializeField] GameObject explosionParticles;
    [SerializeField] GameObject emptyEuler;

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(explosionParticles, gameObject.transform.position, Quaternion.identity);
        Instantiate(emptyEuler, gameObject.transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
