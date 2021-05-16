using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class LeaderBoard : MonoBehaviour
{
    [SerializeField] private ScoreboardEntryUI[] scores;
    private List<ScoreData> Data = new List<ScoreData>(); 
    private void Awake()
    {
        var length = PlayerPrefs.HasKey("score count") ? PlayerPrefs.GetInt("score count") : 0;
        for (var i = 0; i < length; i++)
        {
            Data.Add(new ScoreData(PlayerPrefs.GetString($"name{i}"), PlayerPrefs.GetInt($"score{i}")));
        }
        ShowResult();
    }

    public void AddResult(ScoreData data)
    {
        Data.Add(data);
        PlayerPrefs.SetInt("score count", Data.Count);
        PlayerPrefs.SetString($"name{Data.Count - 1}", data.name);
        PlayerPrefs.SetInt($"name{Data.Count - 1}", data.score);
        ShowResult();
    }

    private void ShowResult()
    {
        Data = Data.OrderBy(data => data.score).ToList();
        for (var i = 0; i < scores.Length; i++)
        {
            if (i >= Data.Count)
            {
                scores[i].Initialise("", (i+1).ToString(), "");
            }
            else
            {
                scores[i].Initialise(Data[i].name, (i+1).ToString(), Data[i].score.ToString());
            }
        }
    }
}
