using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MobileController : MonoBehaviour
{
    public static bool Thrusting;
    public static bool Right;
    public static bool Left;

    public static int ScreenWidth;
    public static int ScreenHeight;
    [SerializeField] Text resText;
    [SerializeField] Text LvlText;

    public static AndroidJavaObject vibrator;
    public static bool vibrCarout;
    public static bool vibrationOn;

    [SerializeField] GameObject menuMenu;
    [SerializeField] GameObject ChooseLvl;


    //Resolution Change bools
    public static bool LowRes = false;
    public static bool HiRes = false;
    public static bool NormRes = !false;
   // GameObject postProcess;

    private void Start()
    {
        //postProcess = GameObject.Find("postProcess");
        if (LowRes)
        {
            ScreenHeight = Display.main.systemHeight  / 2;
            ScreenWidth = Display.main.systemWidth  / 2;
            Screen.SetResolution(ScreenWidth, ScreenHeight, true);
           // postProcess.SetActive(!true);
        }
        if (HiRes)
        {
            ScreenHeight = Display.main.systemHeight;
            ScreenWidth = Display.main.systemWidth;
            Screen.SetResolution(ScreenWidth, ScreenHeight, true);
            //postProcess.SetActive(true);
        }
        if (NormRes)
        {
           ScreenHeight = Display.main.systemHeight - (Display.main.systemHeight /3);
           ScreenWidth = Display.main.systemWidth - (Display.main.systemWidth / 3);
           Screen.SetResolution(ScreenWidth, ScreenHeight, true);
           // postProcess.SetActive(!true);
        }
        resText.text = "ScreenRes: " + ScreenHeight.ToString() + "X" + ScreenWidth.ToString();
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        LvlText.text = "Lvl = " + currentSceneIndex;
    }


    public void ClickDown()
    {
        //Thrusting = true;

        if (vibrationOn && vibrCarout == false)
        {
            Thrusting = true;
            StartCoroutine(vibration());
        }
        else
        {
            Thrusting = true;
        }
    }
    public void vibrationThrust()
    {
        vibrationOn = !vibrationOn;
    }

    public void ClickUp()
    {
        StopAllCoroutines();
        Thrusting = !true;
        vibrCarout = !true;
        
    }
    public void ClickDownLeft()
    {
        Left = true;
    }
    public void ClickUpLeft()
    {
        Left = !true;
    }
    public void ClickDownRight()
    {
        Right = true;
    }
    public void ClickUpRight()
    {
        Right = !true;
    }

    public void CallMenu()
    {
        menuMenu.SetActive(true);
        Time.timeScale = 0;
    }
    public void returnTogame()
    {
        menuMenu.SetActive(false);
        Time.timeScale = 1;
    }
    public void ResolutionLow()
    {
      LowRes = !false;
      HiRes = false;
      NormRes = false;
}
    public void ResolutionHi()
    {
        LowRes = false;
        HiRes = !false;
        NormRes = false;
    }
    public void ResolutionNorm()
    {
        LowRes = false;
        HiRes = false;
        NormRes = !false;
    }

    public void ChooseLvlScreen()
    {
        ChooseLvl.SetActive(true);
    }

    public void SkipLvls()
    {
        menuMenu.SetActive(false);
        Time.timeScale = 1;
        SceneManager.LoadScene(11);
    }
    public void SkipLvls21()
    {
        menuMenu.SetActive(false);
        Time.timeScale = 1;
        SceneManager.LoadScene(21);
    }
    public void SkipLvls38()
    {
        menuMenu.SetActive(false);
        Time.timeScale = 1;
        SceneManager.LoadScene(37);
    }
    public void SkipLvls45()
    {
        menuMenu.SetActive(false);
        Time.timeScale = 1;
        SceneManager.LoadScene(44);
    }

    public void Boss()
    {
        menuMenu.SetActive(false);
        Time.timeScale = 1;
        SceneManager.LoadScene(33);
    }

    IEnumerator vibration()
    {
        if(Thrusting == true)
        {
           vibrCarout = true;
           yield return new WaitForSeconds(0);
           Handheld.Vibrate();
           yield return new WaitForSeconds(0.4f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.4f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.3f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.3f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.3f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.2f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.2f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.2f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.2f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.2f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.3f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.2f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.2f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.2f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.3f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.3f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.4f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.2f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.3f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.2f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.2f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.3f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.4f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.2f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.3f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.2f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.2f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.3f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.4f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.2f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.3f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.2f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.2f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            Handheld.Vibrate();
            yield return new WaitForSeconds(0.1f);
            vibrCarout = !true;
        }
        else
        {
            StopCoroutine(vibration());
            vibrCarout = !true;
        }

    }
}
