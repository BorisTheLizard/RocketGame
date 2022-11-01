using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class optionsMenueAnim : MonoBehaviour
{
    [SerializeField] float scrollSpeed = 0.5f;
    [SerializeField] Image panel;
    [SerializeField] GameObject panelObj;
    bool inUse = false;


    public void Update()
    {
        Debug.Log(Time.timeScale);
        if (inUse == false && panelObj.activeSelf == true && panel.fillAmount < 1)
        {
            Time.timeScale = 1;
            panel.fillAmount += scrollSpeed * Time.deltaTime;
        }
        else if (panel.fillAmount == 1 && panelObj.activeSelf == true)
        {
            inUse = true;
            Time.timeScale = 0;
        }
        else if (panelObj.activeSelf == false)
        {
            inUse = !true;
            Time.timeScale = 1;
            panel.fillAmount = 0;
        }
    }
}