using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SliderController : MonoBehaviour
{
    public Slider musicSlider;
    public Slider sfxSlider;
    float musicSliderValue;
    float sfxSliderValue;

    public void Start()
    {
        musicSlider.value = PlayerPrefs.GetFloat("MusicVolume", musicSliderValue);
        sfxSlider.value = PlayerPrefs.GetFloat("SFXVolume", sfxSliderValue);
    }

    public void ChangeMusicSlider(float value)
    {
        musicSliderValue = value;
        PlayerPrefs.SetFloat("MusicVolume", musicSliderValue);
    }

    public void ChangeSFXSlider(float value)
    {
        sfxSliderValue = value;
        PlayerPrefs.SetFloat("SFXVolume", sfxSliderValue);
    }
}

