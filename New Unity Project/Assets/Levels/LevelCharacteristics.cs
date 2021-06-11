using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TOTAL DICTIONARY
//COPY STRINGS FROM IT AND CREATE DICTIONARIES FOR LEVELS
//{
//        [KeyCode.Q] = "Й",
//        [KeyCode.W] = "Ц",
//        [KeyCode.E] = "У",
//        [KeyCode.R] = "К",
//        [KeyCode.T] = "Е",
//        [KeyCode.Y] = "Н",
//        [KeyCode.U] = "Г",
//        [KeyCode.I] = "Ш",
//        [KeyCode.O] = "Щ",
//        [KeyCode.P] = "З",
//        [KeyCode.LeftBracket] = "Х",
//        [KeyCode.RightBracket] = "Ъ",
//        [KeyCode.A] = "Ф",
//        [KeyCode.S] = "Ы",
//        [KeyCode.D] = "В",
//        [KeyCode.F] = "А",
//        [KeyCode.G] = "П",
//        [KeyCode.H] = "Р",
//        [KeyCode.J] = "О",
//        [KeyCode.K] = "Л",
//        [KeyCode.L] = "Д",
//        [KeyCode.Semicolon] = "Ж",
//        [KeyCode.Quote] = "Э",
//        [KeyCode.Z] = "Я",
//        [KeyCode.X] = "Ч",
//        [KeyCode.C] = "С",
//        [KeyCode.V] = "М",
//        [KeyCode.B] = "И",
//        [KeyCode.N] = "Т",
//        [KeyCode.M] = "Ь",
//        [KeyCode.Comma] = "Б",
//        [KeyCode.Period] = "Ю"
//};

public struct LevelData //храним данные, необходимые для задания уровня
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
            [KeyCode.Q] = "Й",
            [KeyCode.W] = "Ц",
            [KeyCode.E] = "У",
            [KeyCode.R] = "К",
            [KeyCode.T] = "Е",
            [KeyCode.Y] = "Н",
            [KeyCode.U] = "Г",
            [KeyCode.I] = "Ш",
            [KeyCode.O] = "Щ",
            [KeyCode.P] = "З",
            [KeyCode.LeftBracket] = "Х",
            [KeyCode.RightBracket] = "Ъ",
            [KeyCode.A] = "Ф",
            [KeyCode.S] = "Ы",
            [KeyCode.D] = "В",
            [KeyCode.F] = "А",
            [KeyCode.G] = "П",
            [KeyCode.H] = "Р",
            [KeyCode.J] = "О",
            [KeyCode.K] = "Л",
            [KeyCode.L] = "Д",
            [KeyCode.Semicolon] = "Ж",
            [KeyCode.Quote] = "Э",
            [KeyCode.Z] = "Я",
            [KeyCode.X] = "Ч",
            [KeyCode.C] = "С",
            [KeyCode.V] = "М",
            [KeyCode.B] = "И",
            [KeyCode.N] = "Т",
            [KeyCode.M] = "Ь",
            [KeyCode.Comma] = "Б",
            [KeyCode.Period] = "Ю"
        };
    }
}

public class LevelCharacteristics : MonoBehaviour //храним наборы для уровней
{

    private static LevelData[] levelDatas = new[]
    {
        // бесконечный уровень
        new LevelData(
            new Dictionary<KeyCode, string>
            {
                [KeyCode.Q] = "Й",
            [KeyCode.W] = "Ц",
            [KeyCode.E] = "У",
            [KeyCode.R] = "К",
            [KeyCode.T] = "Е",
            [KeyCode.Y] = "Н",
            [KeyCode.U] = "Г",
            [KeyCode.I] = "Ш",
            [KeyCode.O] = "Щ",
            [KeyCode.P] = "З",
            [KeyCode.LeftBracket] = "Х",
            [KeyCode.RightBracket] = "Ъ",
            [KeyCode.A] = "Ф",
            [KeyCode.S] = "Ы",
            [KeyCode.D] = "В",
            [KeyCode.F] = "А",
            [KeyCode.G] = "П",
            [KeyCode.H] = "Р",
            [KeyCode.J] = "О",
            [KeyCode.K] = "Л",
            [KeyCode.L] = "Д",
            [KeyCode.Semicolon] = "Ж",
            [KeyCode.Quote] = "Э",
            [KeyCode.Z] = "Я",
            [KeyCode.X] = "Ч",
            [KeyCode.C] = "С",
            [KeyCode.V] = "М",
            [KeyCode.B] = "И",
            [KeyCode.N] = "Т",
            [KeyCode.M] = "Ь",
            [KeyCode.Comma] = "Б",
            [KeyCode.Period] = "Ю"
            },
            4
            ),

        //1
        new LevelData(
            new Dictionary<KeyCode, string> 
            {
                [KeyCode.F] = "А",
                [KeyCode.J] = "О",
            },
            1
            ),

        //2
        new LevelData(
            new Dictionary<KeyCode, string>
            {
                [KeyCode.F] = "А",
                [KeyCode.J] = "О",
                [KeyCode.D] = "В",
                [KeyCode.K] = "Л",
            },
            2
            ),
    };

    private static int currentLevel = 0;

    public static LevelData CurrentLevelData => levelDatas[currentLevel];

    public void ChooseLevel(int levelIndex)
    {
        currentLevel = levelIndex;
    }
}
