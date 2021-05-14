using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMusic : MonoBehaviour
{
    [FMODUnity.EventRef]
    public string Event;


    public void PlayMusic()
    {
        FMODUnity.RuntimeManager.PlayOneShotAttached(Event, gameObject);
    }

    void Update()
    {
        PlayMusic();
    }
}
