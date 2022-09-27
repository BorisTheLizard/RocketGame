using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyScr : MonoBehaviour
{
    [SerializeField] GameObject explosionParticles;
    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(explosionParticles, gameObject.transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
