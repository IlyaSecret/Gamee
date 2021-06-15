using UnityEngine;
using UnityEngine.UI;

public class AudioSettings : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private Slider audioSlider;
    [Header("Key")]
    [SerializeField] private  string playerPrefsKey = "AudioVolume";

    private void Awake()
    {
        var volume = PlayerPrefs.GetInt(playerPrefsKey, 50);
        audioSource.volume = volume / 100f;
        if (audioSlider == null) return;
        audioSlider.value = volume;
        audioSlider.onValueChanged.AddListener(_ => ChangeVolume((int)audioSlider.value));
    }

    private void ChangeVolume(int volume)
    {
        PlayerPrefs.SetInt(playerPrefsKey, volume);
        PlayerPrefs.Save();
        if (audioSlider == null) return;
        audioSource.volume = volume / 100f;
    }
}
