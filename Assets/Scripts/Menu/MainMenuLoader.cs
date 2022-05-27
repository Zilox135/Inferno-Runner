using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuLoader : MonoBehaviour
{
    [SerializeField] Canvas settingsCanvas;
    [SerializeField] Canvas settingsBGCanvas;
    [SerializeField] Canvas mainMenuCanvas;
    [SerializeField] Canvas mainMenuBGCanvas;
    
    private void Start() 
    {
        settingsCanvas.enabled = false;
        settingsBGCanvas.enabled = false;     
    }
    
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadSettings()
    {
        mainMenuCanvas.enabled = false;
        mainMenuBGCanvas.enabled = false;
        settingsCanvas.enabled = true;
        settingsBGCanvas.enabled = true;
    }

    public void ExitSettings()
    {
        mainMenuCanvas.enabled = true;
        mainMenuBGCanvas.enabled = true;
        settingsCanvas.enabled = false;
        settingsBGCanvas.enabled = false;
    }

    public void LoadMainMenu()
    {
        mainMenuCanvas.enabled = true;
        mainMenuBGCanvas.enabled = true;
        settingsCanvas.enabled = false;
        settingsBGCanvas.enabled = false;
    }
}
