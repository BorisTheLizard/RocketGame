using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormTriggerScr : MonoBehaviour
{
    [SerializeField] Animator anim;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Rocket")
        {
            anim.SetTrigger("attack");
        }
    }
}
