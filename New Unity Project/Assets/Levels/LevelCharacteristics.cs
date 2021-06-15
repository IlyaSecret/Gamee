using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//TOTAL DICTIONARY
//COPY STRINGS FROM IT AND CREATE DICTIONARIES FOR LEVELS
//{
//        [KeyCode.Q] = "�",
//        [KeyCode.W] = "�",
//        [KeyCode.E] = "�",
//        [KeyCode.R] = "�",
//        [KeyCode.T] = "�",
//        [KeyCode.Y] = "�",
//        [KeyCode.U] = "�",
//        [KeyCode.I] = "�",
//        [KeyCode.O] = "�",
//        [KeyCode.P] = "�",
//        [KeyCode.LeftBracket] = "�",
//        [KeyCode.RightBracket] = "�",
//        [KeyCode.A] = "�",
//        [KeyCode.S] = "�",
//        [KeyCode.D] = "�",
//        [KeyCode.F] = "�",
//        [KeyCode.G] = "�",
//        [KeyCode.H] = "�",
//        [KeyCode.J] = "�",
//        [KeyCode.K] = "�",
//        [KeyCode.L] = "�",
//        [KeyCode.Semicolon] = "�",
//        [KeyCode.Quote] = "�",
//        [KeyCode.Z] = "�",
//        [KeyCode.X] = "�",
//        [KeyCode.C] = "�",
//        [KeyCode.V] = "�",
//        [KeyCode.B] = "�",
//        [KeyCode.N] = "�",
//        [KeyCode.M] = "�",
//        [KeyCode.Comma] = "�",
//        [KeyCode.Period] = "�"
//};

public struct LevelData //������ ������, ����������� ��� ������� ������
{
    private readonly Dictionary<KeyCode, string> standardDictionary;

    public readonly Dictionary<KeyCode, string> Dictionary;
    public readonly int MaxEnemies;
    public readonly int LettersAmount;

    public LevelData(Dictionary<KeyCode, string> dictionary, int maxEnemies, int lettersAmount)
    {
        Dictionary = dictionary;
        MaxEnemies = maxEnemies;
        LettersAmount = lettersAmount;
        standardDictionary = new Dictionary<KeyCode, string>
        {
            [KeyCode.Q] = "�",
            [KeyCode.W] = "�",
            [KeyCode.E] = "�",
            [KeyCode.R] = "�",
            [KeyCode.T] = "�",
            [KeyCode.Y] = "�",
            [KeyCode.U] = "�",
            [KeyCode.I] = "�",
            [KeyCode.O] = "�",
            [KeyCode.P] = "�",
            [KeyCode.LeftBracket] = "�",
            [KeyCode.RightBracket] = "�",
            [KeyCode.A] = "�",
            [KeyCode.S] = "�",
            [KeyCode.D] = "�",
            [KeyCode.F] = "�",
            [KeyCode.G] = "�",
            [KeyCode.H] = "�",
            [KeyCode.J] = "�",
            [KeyCode.K] = "�",
            [KeyCode.L] = "�",
            [KeyCode.Semicolon] = "�",
            [KeyCode.Quote] = "�",
            [KeyCode.Z] = "�",
            [KeyCode.X] = "�",
            [KeyCode.C] = "�",
            [KeyCode.V] = "�",
            [KeyCode.B] = "�",
            [KeyCode.N] = "�",
            [KeyCode.M] = "�",
            [KeyCode.Comma] = "�",
            [KeyCode.Period] = "�"
        };
    }
}

public class LevelCharacteristics : MonoBehaviour //������ ������ ��� �������
{
    private static LevelData[] levelDatas = new[]
    {
        //1
        new LevelData(
            new Dictionary<KeyCode, string> 
            {
                [KeyCode.F] = "�",
                [KeyCode.J] = "�",
            },
            1,
            10
            ),

        //2
        new LevelData(
            new Dictionary<KeyCode, string>
            {
                [KeyCode.F] = "�",
                [KeyCode.J] = "�",
                [KeyCode.D] = "�",
                [KeyCode.K] = "�",
            },
            2,
            20
            ),

        //3
        new LevelData(
            new Dictionary<KeyCode, string>
            {
                [KeyCode.F] = "�",
                [KeyCode.J] = "�",
                [KeyCode.D] = "�",
                [KeyCode.K] = "�",
                [KeyCode.S] = "�",
                [KeyCode.L] = "�",
            },
            3,
            20
            ),

        //4
        new LevelData(
            new Dictionary<KeyCode, string>
            {
                [KeyCode.F] = "�",
                [KeyCode.J] = "�",
                [KeyCode.D] = "�",
                [KeyCode.K] = "�",
                [KeyCode.S] = "�",
                [KeyCode.L] = "�",
                [KeyCode.A] = "�",
                [KeyCode.Semicolon] = "�",
            },
            3,
            30
            ),
    };

    public static int CurrentLevel { get; private set; }

    public static LevelData CurrentLevelData => levelDatas[CurrentLevel];

    public void ChooseLevel(int levelIndex)
    {
        CurrentLevel = levelIndex;
    }

    public void MoveToNextLevel()
    {
        CurrentLevel += 1;//����� ��������� �� ������� �� 
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
