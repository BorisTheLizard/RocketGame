using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onDesableCallFadeIn : MonoBehaviour
{
    [SerializeField] GameObject fadeIn;
    [SerializeField] GameObject maneMenu;
    [SerializeField] GameObject optionsMenu;
    [SerializeField] GameObject lvlList;
    public void OnDisable()
    {
        if(maneMenu.active==true || optionsMenu.active==true|| lvlList.active == true)
        {
            fadeIn.SetActive(!true);
        }
        else
        {
            fadeIn.SetActive(true);
        }
    }
}
