using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSettings : MonoBehaviour
{
    public static AudioSettings settings;
    FMOD.Studio.Bus Music;
    FMOD.Studio.Bus SFX;

    float musicVolume;
    float sfxVolume;

    void Awake()
    {
        musicVolume = PlayerPrefs.GetFloat("MusicVolume", 0.5f);
        sfxVolume = PlayerPrefs.GetFloat("SFXVolume", 0.5f);
        if (settings == null)
        {
            DontDestroyOnLoad(gameObject);
            settings = this;
        }
        Music = FMODUnity.RuntimeManager.GetBus("bus:/Music");
        SFX = FMODUnity.RuntimeManager.GetBus("bus:/SFX");
    }

    void Update()
    {
        Music.setVolume(musicVolume);
        SFX.setVolume(sfxVolume);
    }

    public void SetMusicVolumeLevel(float newMusicVolume)
    {
        musicVolume = newMusicVolume;
        PlayerPrefs.SetFloat("MusicVolume", musicVolume);
    }

    public void SetSFXVolumeLevel(float newSFXVolume)
    {
        sfxVolume = newSFXVolume;
        PlayerPrefs.SetFloat("SFXVolume", sfxVolume);
    }
}
