using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class musicVolume : MonoBehaviour
{
    [SerializeField] AudioMixer mixer;

    private void Start()
    {
        //Get the saved music volume, standard = 10f
        float music = PlayerPrefs.GetFloat("musicVolume",10f);

        //Set the music volume to the saved volume
        volumeSlider(music);
    }

    public void volumeSlider(float sliderValue)
    {
        mixer.SetFloat("musicVolume", Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat("musicVolume", sliderValue);
        //PlayerPrefs.Save();
        Debug.Log("Changes saved");
    }
}
