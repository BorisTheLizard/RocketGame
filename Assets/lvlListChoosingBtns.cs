using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lvlListChoosingBtns : MonoBehaviour
{
    [SerializeField] GameObject list1;
    [SerializeField] GameObject list2;

    [SerializeField] GameObject btnForvard;
    [SerializeField] GameObject btnBack;

    [SerializeField] GameObject LvlList;

    //public static int LvlPassedCounter;

    void Start()
    {
        //LvlPassedCounter = SceneManager.GetActiveScene().buildIndex;
    }

    public void ChangeFrwd()
    {
        list1.SetActive(false);
        btnForvard.SetActive(false);
        list2.SetActive(true);
        btnBack.SetActive(true);
    }
    public void ChangeBack()
    {
        list1.SetActive(!false);
        btnForvard.SetActive(!false);
        list2.SetActive(!true);
        btnBack.SetActive(!true);
    }
    public void Return()
    {
        LvlList.SetActive(false);
    }
}
