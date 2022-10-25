using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class lvlSelector : MonoBehaviour
{
    public int lvl;
    public Text lvlText;
    //Button butt;
    //[SerializeField] bool lvlPassed = false;

    private void Start()
    {
        lvlText.text = lvl.ToString();
        //butt = GetComponent<Button>();
        //butt.interactable = false;
    }


    public void OpenScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Fly over " + lvl.ToString());
    }
}
