using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slowDownBarLogic : MonoBehaviour
{
    [SerializeField] GameObject bar;
    [SerializeField] Image filler;
    [SerializeField] float fillerSpeed;
    [SerializeField] GameObject canvas;
    [SerializeField] Button slowDownButton;

    private void Update()
    {
        if (MobileController.slowTimeBool==true)
        { 
            if (filler.fillAmount > 0)
            {
                 filler.fillAmount-=0.2f * fillerSpeed * Time.unscaledDeltaTime;
            }
            else
            {
                TimeManager.timeToSlowdown = true;
            }
        }
        if(filler.fillAmount==0)
        {
            bar.SetActive(false);
            slowDownButton.interactable = false;
            TimeManager.SlowTime = false;
        }
    }
}
