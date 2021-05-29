using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static float timeStart;
    public Text textTimer;
    public Text score;
    public Text finalScore;
    void Start()
    {
        textTimer.text = timeStart.ToString();
    }

    void Update()
    {
        timeStart += Time.deltaTime;
        textTimer.text = Mathf.Round(timeStart).ToString();
        score.text = textTimer.text;
        finalScore.text = textTimer.text;
    }
}
