using UnityEngine;
using UnityEngine.UI;

public class FullScreen : MonoBehaviour
{
    [SerializeField] private Toggle toggle;

    private const string Key = "FullScreen";

    private void Awake()
    {
        var isFullScreen = PlayerPrefs.GetInt(Key, 1) == 1;
        toggle.isOn = isFullScreen;
        toggle.onValueChanged.AddListener(_ => ChangeState(toggle.isOn));
    }

    private void ChangeState(bool check)
    {
        PlayerPrefs.SetInt(Key, check ? 1 : 0);
        PlayerPrefs.Save();
    }
}
