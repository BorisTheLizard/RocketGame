using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnemyScr : MonoBehaviour
{
    [SerializeField] GameObject[] enemyPuck;
    [SerializeField] float timeM = 0.1f;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(timeM);
        enemyPuck[0].SetActive(true);
        yield return new WaitForSeconds(timeM);
        enemyPuck[1].SetActive(true);
        yield return new WaitForSeconds(timeM);
        enemyPuck[2].SetActive(true);
        yield return new WaitForSeconds(timeM);
        enemyPuck[3].SetActive(true);
        yield return new WaitForSeconds(timeM);
        enemyPuck[4].SetActive(true);
        yield return new WaitForSeconds(timeM);
        enemyPuck[5].SetActive(true);
        yield return new WaitForSeconds(timeM);
        Destroy(this);
    }
}
