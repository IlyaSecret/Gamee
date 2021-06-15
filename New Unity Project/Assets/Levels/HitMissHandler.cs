using UnityEngine;
using UnityEngine.UI;

public class HitMissHandler : MonoBehaviour
{
    [SerializeField] private Text hitText;
    [SerializeField] private Text missText;

    private string hitPlayerPrefsKey => $"{LevelCharacteristics.CurrentLevel}_Hit";
    private string missPlayerPrefsKey => $"{LevelCharacteristics.CurrentLevel}_Miss";

    public void ResetTransform()
    {
        GetComponent<RectTransform>().localPosition = new Vector3();
    }

    public void SaveHitMissData()
    {
        PlayerPrefs.SetInt(hitPlayerPrefsKey, int.Parse(hitText.text));
        PlayerPrefs.SetInt(missPlayerPrefsKey, int.Parse(missText.text));
        PlayerPrefs.Save();
    }
}
