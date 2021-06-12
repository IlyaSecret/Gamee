using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepsScript : MonoBehaviour
{
    [FMODUnity.EventRef]
    public string InputSound;
    bool playerIsMoving;
    public float Speed;


    void Start()
    {
        InvokeRepeating("CallFootsteps", 0, Speed);
    }

    void Update()
    {
        if (Input.GetAxis("Horizontal") <= 0.01f)
            playerIsMoving = true;
        else
            playerIsMoving = false;
    }

    void CallFootsteps()
    {
        if (playerIsMoving)
            FMODUnity.RuntimeManager.PlayOneShot(InputSound);
    }
}
