using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatorSpeedWorms : MonoBehaviour
{
    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
        anim.speed = Random.Range(0.8f, 3f);
    }
}
