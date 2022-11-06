using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class faseOutStart : MonoBehaviour
{
    [SerializeField]Image fadeOut;
    [SerializeField] float fadeSpeed = 10;

    private void Update()
    {
        if (fadeOut.fillAmount > 0)
        {
            fadeOut.fillAmount -= 0.2f * fadeSpeed * Time.unscaledDeltaTime;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
