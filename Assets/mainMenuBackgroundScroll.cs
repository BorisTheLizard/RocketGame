using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainMenuBackgroundScroll : MonoBehaviour
{
    [SerializeField] float scrollSpeed = 0.5f;
    [SerializeField] Image panel;
    [SerializeField] GameObject panelObj;
    bool inUse = false;


    public void Update()
    {
        if (inUse==false && panelObj.activeSelf==true && panel.fillAmount<1)
        {
            TimeManager.StopTime = false;
            panel.fillAmount += scrollSpeed * Time.deltaTime;
        }
        else if (panel.fillAmount == 1 && panelObj.activeSelf == true)
        {
            TimeManager.StopTime = !false;
            inUse = true;
        }
        else if (panelObj.activeSelf==false)
        {
            inUse = !true;
            panel.fillAmount = 0;
        }
    }
}
