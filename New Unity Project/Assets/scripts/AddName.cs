using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddName : MonoBehaviour
{
    [SerializeField] private Text player;
    [SerializeField] private Text score;
    [SerializeField] private LeaderBoard leaderBoard;

    public void SaveResult()
    {
        leaderBoard.AddResult(new ScoreData(player.text, int.Parse(score.text)));
    }
}
