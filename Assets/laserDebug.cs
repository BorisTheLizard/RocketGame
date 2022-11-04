using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserDebug : MonoBehaviour
{
    [SerializeField] float laserPower = 100f;
    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void OnParticleCollision(GameObject other)
    {
        float randX = Random.Range(-1000, 1000);
        float randY = Random.Range(-1000, 1000);

        if (other.tag == "Rocket")
        {
            audioSource.Play();
            other.GetComponent<Rigidbody>().AddForce(randX, randY, 0 * laserPower, ForceMode.Impulse);
            //other.GetComponent<Rigidbody>().angularDrag = 5;
            //other.GetComponent<Rigidbody>().drag = 5;
            //other.GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
