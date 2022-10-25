using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lvlScript : MonoBehaviour
{
    public void Pass()
    {
        int currentLvl = SceneManager.GetActiveScene().buildIndex;
        if (currentLvl >= PlayerPrefs.GetInt("lvlsUnlocked"))
        {
            PlayerPrefs.SetInt("lvlsUnlocked", currentLvl + 1);
        }
        Debug.Log("lvl" + PlayerPrefs.GetInt("lvlsUnlocked")+ " unlocked");

    }

}
