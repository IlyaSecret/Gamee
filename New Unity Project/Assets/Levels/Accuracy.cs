using System;
using UnityEngine;
using UnityEngine.UI;

public class Accuracy : MonoBehaviour
{
    private string hitPlayerPrefsKey => $"{levelIndex}_Hit";
    private string missPlayerPrefsKey => $"{levelIndex}_Miss";

    [SerializeField] private int levelIndex;

    private void Awake()
    {
        var hit = PlayerPrefs.GetInt(hitPlayerPrefsKey, 0);
        var miss = PlayerPrefs.GetInt(missPlayerPrefsKey, 0);
        var result = hit == 0 ? 0 : Math.Round(100f * hit / (hit + miss), 2);
        GetComponent<Text>().text = $"{result}%";
    }
}
