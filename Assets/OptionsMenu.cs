using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour
{

    [Header("Audio")]
    [SerializeField] AudioMixer audioMixer;
    [SerializeField] Slider masterVolumeSlider;
    [SerializeField] Slider musicVolumeSlider;
    [SerializeField] Slider sfxVolumeSlider;

    [SerializeField] Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {
        masterVolumeSlider.value = PlayerPrefs.GetFloat("MasterVolume");
        musicVolumeSlider.value = PlayerPrefs.GetFloat("MusicVolume");
        sfxVolumeSlider.value = PlayerPrefs.GetFloat("SfxVolume");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetMasterVolume(){
        audioMixer.SetFloat("MasterVolume", ConvertToDec(masterVolumeSlider.value));
        PlayerPrefs.SetFloat("MasterVolume", masterVolumeSlider.value);
    }

    public void SetMusicVolume(){
        audioMixer.SetFloat("MusicVolume", ConvertToDec(musicVolumeSlider.value));
        PlayerPrefs.SetFloat("MusicVolume", musicVolumeSlider.value);
    }

    public void SetSfxVolume(){
        audioMixer.SetFloat("SfxVolume", ConvertToDec(sfxVolumeSlider.value));
        PlayerPrefs.SetFloat("SfxVolume", sfxVolumeSlider.value);
    }

    float ConvertToDec(float sliderValue){
        return Mathf.Log10(Mathf.Max(sliderValue, 0.0001f)) * 20;
    }

    public void OpenOptions(){
        canvas.enabled = true;
    }

    public void CloseOptions(){
        canvas.enabled = false;
    }
}
