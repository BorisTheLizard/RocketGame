using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class lvlSelector : MonoBehaviour
{
    public int lvl;
    public Text lvlText;

    private void Start()
    {
        lvlText.text = lvl.ToString();
    }


    public void OpenScene()
    {
        TimeManager.StopTime = false;
        SceneManager.LoadScene("Fly over " + lvl.ToString());
    }
}
