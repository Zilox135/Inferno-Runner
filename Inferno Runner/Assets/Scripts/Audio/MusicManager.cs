using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{
    [SerializeField] Slider musicSlider;
    [SerializeField] Slider masterSlider;
    private GameObject musicObj;
    private AudioSource source;

    void Start()
    {
        musicObj = GameObject.FindWithTag("GameMusic");
        source = musicObj.GetComponent<AudioSource>();

        if (!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1f);
            LoadMusicVolume();
        }
        else
        {
            LoadMusicVolume();
        }

        if (!PlayerPrefs.HasKey("masterVolume"))
        {
            PlayerPrefs.SetFloat("masterVolume", 1f);
            LoadMasterVolume();
        }
        else
        {
            LoadMasterVolume();
        }
    }

    public void ChangeMusicVolume()
    {
        source.volume = musicSlider.value;
        SaveMusicVolume();
    }

    public void ChangeMasterVolume()
    {
        AudioListener.volume = masterSlider.value;
        SaveMasterVolume();
    }

    public void LoadMusicVolume()
    {
        musicSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }

    public void SaveMusicVolume()
    {
        PlayerPrefs.SetFloat("musicVolume", musicSlider.value);
    }

    public void LoadMasterVolume()
    {
        masterSlider.value = PlayerPrefs.GetFloat("masterVolume");
    }

    public void SaveMasterVolume()
    {
        PlayerPrefs.SetFloat("masterVolume", masterSlider.value);
    }
}
