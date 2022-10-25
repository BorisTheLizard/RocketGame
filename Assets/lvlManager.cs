using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class lvlManager : MonoBehaviour
{
    int lvlsUnlocked;
    public Button[] buttons;

    void Start()
    {
        lvlsUnlocked = PlayerPrefs.GetInt("lvlsUnlocked", 1);

        for (int i =0; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
        }
        for (int i = 0; i < lvlsUnlocked; i++)
        {
            buttons[i].interactable = true;
        }
    }

    public void loadLvl(int levelIndex)
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(levelIndex);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
