using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_shot : MonoBehaviour
{
    private FMOD.Studio.EventInstance instance;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            instance = FMODUnity.RuntimeManager.CreateInstance("event:/Sounds/Shots");
            instance.start();
            instance.release();
        }
    }
}
