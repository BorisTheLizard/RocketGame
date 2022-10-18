using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossDown : MonoBehaviour
{
    [SerializeField] GameObject timeLine;
    [SerializeField] GameObject rocket;
    [SerializeField] Transform tpPoint;
    private void Update()
    {
        transform.Translate (-Vector3.up * 10 * Time.deltaTime);
    }
    private void Start()
    {
        StartCoroutine(end());
    }
    private IEnumerator end() 
    {
        yield return new WaitForSeconds(5);
        rocket.transform.position = tpPoint.position;
        timeLine.SetActive(!true);
    }
}
