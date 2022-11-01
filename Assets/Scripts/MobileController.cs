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

    //UI
    [SerializeField] GameObject maneMenu;

    [SerializeField] GameObject OptionsMenu;
    [SerializeField] GameObject mainChsLvlReturn;
    [SerializeField] GameObject gameplayButtons;
    //choose LVL
    [SerializeField] GameObject ChooseLvl;
    [SerializeField] GameObject mainChooseLvl;
    [SerializeField] Animator chooseLvlAnim;

    //Resolution Change bools
    public static bool LowRes = false;
    public static bool NormRes = !false;
    public GameObject postProcess;
    public static bool PostProcessBool = false;

    //music
    GameObject music;
    [SerializeField] GameObject slider;
    
    public static bool musicPlayBool = !false;

    private void Start()
    {
        
        music = GameObject.Find("musicPlay");
        //audioSource = music.GetComponent<AudioSource>();
        //musicMixer = music.GetComponent<AudioMixer>();
        //Debug.Log(audioSource);
        if (LowRes)
        {
            Application.targetFrameRate = 55;
            ScreenHeight = Display.main.systemHeight  / 2;
            ScreenWidth = Display.main.systemWidth  / 2;
            Screen.SetResolution(ScreenWidth, ScreenHeight, true);
        }

        if (NormRes)
        {
           ScreenHeight = Display.main.systemHeight - (Display.main.systemHeight /3);
           ScreenWidth = Display.main.systemWidth - (Display.main.systemWidth / 3);
           Screen.SetResolution(ScreenWidth, ScreenHeight, true);
        }
        resText.text = "ScreenRes: " + ScreenHeight.ToString() + "X" + ScreenWidth.ToString();
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        LvlText.text = "Lvl = " + currentSceneIndex;

        //postProcess
        if (PostProcessBool)
        {
            postProcess.SetActive(true);
        }
        else
        {
            postProcess.SetActive(!true);
        }

        //music
        if (musicPlayBool)
        {
            music.SetActive(true);
        }
        else
        {
            music.SetActive(!true);
        }
    }


    //ROCKET Controller
    public void ClickDown()
    {
        Thrusting = true;
    }
    public void ClickUp()
    {
        Thrusting = !true;
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

    //StartingScreen
    public void MainScreenChooseLvl()
    {
        mainChooseLvl.SetActive(true);
    }
    public void MainScreenChsLvlReturn()
    {
        mainChsLvlReturn.SetActive(false);
    }



    //UI BUTTONS__________________________

    //menu button
    public void CallMenu()
    {
        maneMenu.SetActive(true);
        gameplayButtons.SetActive(false);
        Time.timeScale = 0;
    }

    //Maim Menu
    public void ChooseLvlScreen()
    {
        ChooseLvl.SetActive(true);
        chooseLvlAnim.SetTrigger("callAnim");
        Debug.Log("AnimCalled");
        maneMenu.SetActive(false);
    }
    public void OptionsMenuCall()
    {
        OptionsMenu.SetActive(true);
        maneMenu.SetActive(false);
    }
    public void maneMenuReturn()
    {
        maneMenu.SetActive(false);
        gameplayButtons.SetActive(!false);
        Time.timeScale = 1;
    }
    public void exitGame()
    {
        Application.Quit();
    }


    //Options Menu
    public void ResolutionLow()
    {
      LowRes = !false;
      NormRes = false;
    }
    public void ResolutionNorm()
    {
        LowRes = false;
        NormRes = !false;
    }
    public void PostProcess()
    {
        PostProcessBool = !PostProcessBool;
    }
    public void MusicPlay()
    {
        musicPlayBool = !musicPlayBool;
        if (musicPlayBool)
        {
            //music.SetActive(true);
            //slider.SetActive(true);
        }else
        {
            //music.SetActive(!true);
            //slider.SetActive(!true);
        }
    }
    public void returnTogame()
    {
        OptionsMenu.SetActive(false);
        gameplayButtons.SetActive(!false);
        Time.timeScale = 1;
    }

}
