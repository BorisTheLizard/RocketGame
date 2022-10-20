using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserDebug : MonoBehaviour
{
    [SerializeField] float laserPower = 100f;
    private void OnParticleCollision(GameObject other)
    {
        float randX = Random.Range(-100, 100);
        float randY = Random.Range(-100, 100);

        if (other.tag == "Rocket")
        {
            other.GetComponent<Rigidbody>().AddForce(randX, randY, 0 * laserPower, ForceMode.Impulse);
        }
    }
}
