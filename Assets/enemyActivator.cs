using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyActivator : MonoBehaviour
{
    [SerializeField] GameObject[] enemy;
    [SerializeField] float MaxTime = 0.2f;
    [SerializeField] float waitTime;

    public void Start()
    {
        
/*        foreach(GameObject enemyR in enemy)
        {
            // Invoke("activator", Random.Range(0.1f, 1f));
            gameObject.SetActive(true);
        }*/
       for(int i=0; i < enemy.Length; i++)
        {
            if (Time.time > waitTime)
            {
                waitTime = Time.time + MaxTime;
                enemy[i].SetActive(true);
            }
            
            //Invoke("activator", Random.Range(0, 1));
        }
    }
    void activator()
    {
        //gameObject.SetActive(true);
    }
}
