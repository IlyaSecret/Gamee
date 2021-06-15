using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject Pause_Menu;
    [SerializeField] private UnityEvent Paused;
    [SerializeField] private UnityEvent NotPaused;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 1 - Time.timeScale;
            Pause_Menu.SetActive(Time.timeScale == 0);
            if (Time.timeScale == 0) Paused.Invoke();
            else NotPaused.Invoke();
        }
    }

    public void LoadMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }

    public void Restart()
    {
        Time.timeScale = 1;
        Timer.timeStart = 0;
        SceneManager.LoadScene("SampleScene");
    }
}
