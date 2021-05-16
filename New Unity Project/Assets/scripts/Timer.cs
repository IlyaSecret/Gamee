using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeStart;
    public Text textTimer;
    void Start()
    {
        textTimer.text = timeStart.ToString("F0");
    }

    void Update()
    {
        timeStart += Time.deltaTime;
        textTimer.text = timeStart.ToString("F0");
    }
}
