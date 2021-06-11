using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    public LevelData(Dictionary<KeyCode, string> dictionary, int maxEnemies)
    {
        Dictionary = dictionary;
        MaxEnemies = maxEnemies;
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
        // ����������� �������
        new LevelData(
            new Dictionary<KeyCode, string>
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
            },
            4
            ),

        //1
        new LevelData(
            new Dictionary<KeyCode, string> 
            {
                [KeyCode.F] = "�",
                [KeyCode.J] = "�",
            },
            1
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
