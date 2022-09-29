using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyerTrigg : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
