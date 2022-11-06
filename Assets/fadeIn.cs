using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fadeIn : MonoBehaviour
{
    [SerializeField] Image fadeInImg;
    [SerializeField] float fadeSpeed = 10;
    bool timeToFade=false;

    private void OnEnable()
    {
        Invoke("changeBool", 0.7f);
    }
    public void Update()
    {
        if (timeToFade)
        {
        if (fadeInImg.fillAmount != 1)
        {
             fadeInImg.fillAmount += 0.2f * fadeSpeed * Time.unscaledDeltaTime;
        }
        }

    }
    void changeBool()
    {
        timeToFade = true;
    }
}