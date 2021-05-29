using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

    public class ScoreboardEntryUI : MonoBehaviour
    {
        [SerializeField] private Text entryNameText = null;
        [SerializeField] private Text entryScoreText = null;
        [SerializeField] private Text entryPlaceText = null;

        public void Initialise(string name, string place, string score)
        {
            entryNameText.text = name;
            entryPlaceText.text = place;
            entryScoreText.text = score;
        }
    }


public class ScoreData
{
    public readonly string name;
    public readonly int score;

    public ScoreData(string name, int score)
    {
        this.name = name;
        this.score = score;
    }
}

