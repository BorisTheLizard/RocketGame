using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOnCollisionRocks : MonoBehaviour
{
    [SerializeField] int Maxhits = 6;
    [SerializeField] GameObject crashParts;

    private void OnCollisionEnter(Collision collision)
    {
        if (Maxhits > 0)
        {
            Maxhits -= 1;
        }
        else
        {
            Instantiate(crashParts, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }

}
