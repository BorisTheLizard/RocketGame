using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulbBossAI : MonoBehaviour
{
    Animator anim;
    [SerializeField] ParticleSystem teleportParts;
    [SerializeField] GameObject BossMoveController;


    private void Start()
    {
        anim = GetComponent<Animator>();

    }
    public void CycleOne()
    {
        StartCoroutine(TimeLine());
    }
    public void CycleTwo()
    {
        StartCoroutine(TimeLineTwo());
    }
    public void CycleThree()
    {
        StartCoroutine(LineThree());
    }
    public void CycleFourth()
    {
        StartCoroutine(lastSignal());
    }

    private IEnumerator TimeLine()
    {
        Debug.Log("START corot");
        yield return new WaitForSeconds(2);
        IDLE1();
        yield return new WaitForSeconds(3);
        Attack();
        yield return new WaitForSeconds(6);
        IDLE();
        yield return new WaitForSeconds(6);
        Attack();
        yield return new WaitForSeconds(6);
        IDLE1();
        yield return new WaitForSeconds(6);
        Attack();
        yield return new WaitForSeconds(6);
        IDLE();
        yield return new WaitForSeconds(6);
        Attack();
        yield return new WaitForSeconds(6);
        IDLE1();
        yield return new WaitForSeconds(6);
        cast();
    }
    private IEnumerator TimeLineTwo()
    {
        yield return new WaitForSeconds(2);
        IDLE1();
        yield return new WaitForSeconds(6);
        Attack1();
        yield return new WaitForSeconds(2);
        IDLE1();
        yield return new WaitForSeconds(4);
        Attack1();
        yield return new WaitForSeconds(6);
        IDLE1();
        yield return new WaitForSeconds(6);
        Attack();
        yield return new WaitForSeconds(4);
        IDLE1();
        yield return new WaitForSeconds(6);
        Attack();
        yield return new WaitForSeconds(4);
        Attack1();
        yield return new WaitForSeconds(6);
        IDLE();
        yield return new WaitForSeconds(6);
        Attack();
        yield return new WaitForSeconds(4);
        Attack();
        yield return new WaitForSeconds(2);
        cast();
    }
    private IEnumerator LineThree()
    {
        yield return new WaitForSeconds(6);
        Attack1();
        yield return new WaitForSeconds(4);
        IDLE();
        yield return new WaitForSeconds(6);
        Attack();
        yield return new WaitForSeconds(4);
        Attack1();
        yield return new WaitForSeconds(4);
        IDLE1();
        yield return new WaitForSeconds(4);
        Attack1();
        yield return new WaitForSeconds(3);
        IDLE1();
        yield return new WaitForSeconds(4);
        Attack1();
        yield return new WaitForSeconds(4);
        Attack();
        yield return new WaitForSeconds(6);
        IDLE();
        yield return new WaitForSeconds(3);
        Attack1();
        yield return new WaitForSeconds(3);
        Attack1();
        yield return new WaitForSeconds(4);
        Attack();
        yield return new WaitForSeconds(5);
        IDLE1();
        yield return new WaitForSeconds(3);
        cast();
    }
    private IEnumerator lastSignal()
    {
        yield return new WaitForSeconds(4);
        Attack1();
        yield return new WaitForSeconds(4);
        Attack();
        yield return new WaitForSeconds(3);
        IDLE1();
        yield return new WaitForSeconds(4);
        Attack();
        yield return new WaitForSeconds(3);
        IDLE1();
        yield return new WaitForSeconds(3);
        Attack1();
        yield return new WaitForSeconds(3);
        IDLE1();
        yield return new WaitForSeconds(4);
        Attack();
        yield return new WaitForSeconds(6);
        IDLE1();
        yield return new WaitForSeconds(6);
        Attack();
        yield return new WaitForSeconds(6);
        IDLE();
        yield return new WaitForSeconds(3);
        Attack1();
        yield return new WaitForSeconds(3);
        Attack1();
        yield return new WaitForSeconds(3);
        Attack1();
        yield return new WaitForSeconds(6);
        Attack();
        yield return new WaitForSeconds(2);
        Attack1();
        yield return new WaitForSeconds(2);
        Attack1();
        yield return new WaitForSeconds(3);
        Attack1();
        yield return new WaitForSeconds(3);
        Attack1();
        yield return new WaitForSeconds(2);
        Attack1();
        yield return new WaitForSeconds(6);
        IDLE();
    }


    private void Attack()
    {
        teleportParts.Play();
        anim.SetTrigger("attack");
        BossMoveController.GetComponent<bossPosition>().enabled = !false;
    }
    private void Attack1()
    {
        teleportParts.Play();
        anim.SetTrigger("attack1");
        BossMoveController.GetComponent<bossPosition>().enabled = !false;
    }
    private void IDLE()
    {
        anim.SetTrigger("IDLE");
        BossMoveController.GetComponent<bossPosition>().enabled = false;
    }
    private void IDLE1()
    {
        anim.SetTrigger("IDLE1");
        BossMoveController.GetComponent<bossPosition>().enabled = false;
    }
    private void cast()
    {
        anim.SetTrigger("cast");
        StopCoroutine(LineThree());
    }
    public void death()
    {
        anim.SetTrigger("death");
        BossMoveController.GetComponent<bossPosition>().enabled = false;
        BossMoveController.GetComponent<bossDown>().enabled = true;
    }
}
