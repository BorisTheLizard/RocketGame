using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class intencityLight : MonoBehaviour
{
    Light intencity;
    [SerializeField] float min = 5;
    [SerializeField] float max = 15;
    void Start()
    {
        intencity = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        intencity.intensity = Random.Range(min, max);
    }
}
