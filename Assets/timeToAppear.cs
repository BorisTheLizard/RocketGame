using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeToAppear : MonoBehaviour
{
    Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void Awake()
    {
        Invoke("Mover", 1.5f);
    }
    void Mover()
    {
        anim.enabled = true;
    }
}
