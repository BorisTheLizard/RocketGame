using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyMiddleArea : MonoBehaviour
{
    [SerializeField] GameObject middleArea;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "triggerrator")
        {
            Destroy(middleArea);
        }
    }
}
