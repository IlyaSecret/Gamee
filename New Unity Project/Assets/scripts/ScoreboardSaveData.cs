using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Scoreboards
{
    [Serializable]
    public class ScoreboardSaveData
    {
        public List<ScoreboardEntryData> highscores = new List<ScoreboardEntryData>();
    }   
}

