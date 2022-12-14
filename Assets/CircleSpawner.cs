using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSpawner : MonoBehaviour
{
    [SerializeField] GameObject ball;
    [SerializeField] Transform direction;
    [SerializeField] float rotationDeg = 45;
    bool waiting;
    [SerializeField] int TimesToCreate = 0;
    [SerializeField] int TimesToCreateMax = 8;
    [SerializeField] float forcePower = 2f;
    [SerializeField] float SpawnDelay = 0.5f;
    

    private void Start()
    {
        float RotatorZ = Random.Range(20, 60);
        transform.Rotate(0, 0, RotatorZ);
    }

    private void Update()
    {
        if(waiting == false)
        {
              StartCoroutine(Spawner());
        }
        else if (TimesToCreate == TimesToCreateMax)
        {
            Destroy(this.gameObject);
        }
    }

    private IEnumerator Spawner()
    {
        waiting = true;
        yield return new WaitForSeconds(SpawnDelay);
        GameObject projectile = Instantiate(ball, direction.transform.position, transform.rotation);
        projectile.GetComponent<Rigidbody>().AddRelativeForce(Vector3.right * forcePower,ForceMode.Impulse);
        transform.Rotate(0, 0, rotationDeg);
        TimesToCreate += 1;
        waiting = !true;
    }
}
