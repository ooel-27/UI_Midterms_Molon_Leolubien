using UnityEngine;
using UnityEngine.UI;

public class AudioSettingsUI : MonoBehaviour
{
    [SerializeField] private Slider masterSlider;
    [SerializeField] private Slider musicSlider;
    [SerializeField] private Slider sfxSlider;

    void OnEnable()
    {
        if (AudioManager.Instance != null)
        {
            masterSlider.value = PlayerPrefs.GetFloat("MasterVolume", 0.8f);
            musicSlider.value  = PlayerPrefs.GetFloat("MusicVolume", 0.8f);
            sfxSlider.value    = PlayerPrefs.GetFloat("SFXVolume", 0.8f);

            masterSlider.onValueChanged.AddListener(AudioManager.Instance.SetMasterVolume);
            musicSlider.onValueChanged.AddListener(AudioManager.Instance.SetMusicVolume);
            sfxSlider.onValueChanged.AddListener(AudioManager.Instance.SetSFXVolume);
        }
    }

    void OnDisable()
    {
        masterSlider.onValueChanged.RemoveAllListeners();
        musicSlider.onValueChanged.RemoveAllListeners();
        sfxSlider.onValueChanged.RemoveAllListeners();
    }
}