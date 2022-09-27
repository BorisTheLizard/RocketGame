using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOnTime : MonoBehaviour
{
    [SerializeField] float timeToWait = 1f;
    private void Start()
    {
        StartCoroutine(DestroyIt());
    }

    IEnumerator DestroyIt()
    {
        yield return new WaitForSeconds(timeToWait);
        Destroy(this.gameObject);
    }
}
