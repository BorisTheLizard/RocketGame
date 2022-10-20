using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeToAppear : MonoBehaviour
{
    Animator anim;
    [SerializeField] float time = 1.5f;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void Awake()
    {
        Invoke("Mover", time);
    }
    void Mover()
    {
        anim.enabled = true;
    }
}
