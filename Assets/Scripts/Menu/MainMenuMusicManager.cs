using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuMusicManager : MonoBehaviour
{
    public Slider menuMusicSlider;
    private AudioSource source;
    
    private void Awake() 
    {
       source = GetComponent<AudioSource>();
    }
    
    void Start()
    {
        if (!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", .5f);
            LoadMusicVolume();
        }
        else
        {
            LoadMusicVolume();
        }
    }

    private void Update()
    {
        PlayMenuMusic();
    }

    private void PlayMenuMusic()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(0) && !source.isPlaying)
        {
            source.Play();
        }
        else if (!source.isPlaying)
        {
            source.Pause();
        }
    }

    public void ChangeMusicVolume()
    {
        source.volume = menuMusicSlider.value;
        SaveMusicVolume();
    }

    private void LoadMusicVolume()
    {
        menuMusicSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }

    private void SaveMusicVolume()
    {
        PlayerPrefs.SetFloat("musicVolume", menuMusicSlider.value);
    }
}
