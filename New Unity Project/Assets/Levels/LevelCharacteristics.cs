using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TOTAL DICTIONARY
//COPY STRINGS FROM IT AND CREATE DICTIONARIES FOR LEVELS
//{
//        [KeyCode.Q] = "É",
//        [KeyCode.W] = "Ö",
//        [KeyCode.E] = "Ó",
//        [KeyCode.R] = "Ê",
//        [KeyCode.T] = "Å",
//        [KeyCode.Y] = "Í",
//        [KeyCode.U] = "Ã",
//        [KeyCode.I] = "Ø",
//        [KeyCode.O] = "Ù",
//        [KeyCode.P] = "Ç",
//        [KeyCode.LeftBracket] = "Õ",
//        [KeyCode.RightBracket] = "Ú",
//        [KeyCode.A] = "Ô",
//        [KeyCode.S] = "Û",
//        [KeyCode.D] = "Â",
//        [KeyCode.F] = "À",
//        [KeyCode.G] = "Ï",
//        [KeyCode.H] = "Ð",
//        [KeyCode.J] = "Î",
//        [KeyCode.K] = "Ë",
//        [KeyCode.L] = "Ä",
//        [KeyCode.Semicolon] = "Æ",
//        [KeyCode.Quote] = "Ý",
//        [KeyCode.Z] = "ß",
//        [KeyCode.X] = "×",
//        [KeyCode.C] = "Ñ",
//        [KeyCode.V] = "Ì",
//        [KeyCode.B] = "È",
//        [KeyCode.N] = "Ò",
//        [KeyCode.M] = "Ü",
//        [KeyCode.Comma] = "Á",
//        [KeyCode.Period] = "Þ"
//};

public struct LevelData
{
    private readonly Dictionary<KeyCode, string> standardDictionary;

    public readonly Dictionary<KeyCode, string> Dictionary;
    public readonly int MaxEnemies;

    public LevelData(Dictionary<KeyCode, string> dictionary, int maxEnemies)
    {
        Dictionary = dictionary;
        MaxEnemies = maxEnemies;
        standardDictionary = new Dictionary<KeyCode, string>
        {
            [KeyCode.Q] = "É",
            [KeyCode.W] = "Ö",
            [KeyCode.E] = "Ó",
            [KeyCode.R] = "Ê",
            [KeyCode.T] = "Å",
            [KeyCode.Y] = "Í",
            [KeyCode.U] = "Ã",
            [KeyCode.I] = "Ø",
            [KeyCode.O] = "Ù",
            [KeyCode.P] = "Ç",
            [KeyCode.LeftBracket] = "Õ",
            [KeyCode.RightBracket] = "Ú",
            [KeyCode.A] = "Ô",
            [KeyCode.S] = "Û",
            [KeyCode.D] = "Â",
            [KeyCode.F] = "À",
            [KeyCode.G] = "Ï",
            [KeyCode.H] = "Ð",
            [KeyCode.J] = "Î",
            [KeyCode.K] = "Ë",
            [KeyCode.L] = "Ä",
            [KeyCode.Semicolon] = "Æ",
            [KeyCode.Quote] = "Ý",
            [KeyCode.Z] = "ß",
            [KeyCode.X] = "×",
            [KeyCode.C] = "Ñ",
            [KeyCode.V] = "Ì",
            [KeyCode.B] = "È",
            [KeyCode.N] = "Ò",
            [KeyCode.M] = "Ü",
            [KeyCode.Comma] = "Á",
            [KeyCode.Period] = "Þ"
        };
    }
}

public class LevelCharacteristics : MonoBehaviour
{
    private static LevelData[] levelDatas = new[]
    {
        //1
        new LevelData(
            new Dictionary<KeyCode, string> 
            {
                [KeyCode.Q] = "É",
                [KeyCode.W] = "Ö",
                [KeyCode.E] = "Ó",
            },
            5
            ),
    };
    private static int currentLevel = 0;

    public static LevelData CurrentLevelData => levelDatas[currentLevel];

    public void ChooseLevel(int levelIndex)
    {
        currentLevel = levelIndex;
    }
}
