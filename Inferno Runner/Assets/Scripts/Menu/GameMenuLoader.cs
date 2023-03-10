using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenuLoader : MonoBehaviour
{
    [SerializeField] Canvas settingsCanvas;
    [SerializeField] Canvas pauseMenuCanvas;
    [SerializeField] Canvas healthCanvas;
    [SerializeField] Canvas scoreCanvas;
    [SerializeField] Canvas deathCanvas;
    private MusicPlayer musicPlayer;
    private ControlsUI pauseControlsUI;
    private bool isPaused = false;    

    public bool IsPaused
    {
        get { return isPaused; }
    }

    private void Awake() 
    {
        musicPlayer = FindObjectOfType<MusicPlayer>();
        pauseControlsUI = FindObjectOfType<ControlsUI>();
    }
    
    private void Start() 
    {
        Time.timeScale = 1;
        pauseMenuCanvas.enabled = false;
        settingsCanvas.enabled = false;
    }

    private void Update() 
    {
        PauseGame();
    }
    
    public void ReloadLevel()
    {
        SceneManager.LoadScene(1);
        AudioListener.pause = false;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void PauseGame()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            AudioListener.pause = true;
            healthCanvas.enabled = false;
            scoreCanvas.enabled = false;
            deathCanvas.enabled = false;
            pauseMenuCanvas.enabled = true;
            pauseControlsUI.PauseControls.enabled = true;
            isPaused = true;
        }
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        AudioListener.pause = false;
        healthCanvas.enabled = true;
        scoreCanvas.enabled = true;
        pauseMenuCanvas.enabled = false;
        settingsCanvas.enabled = false;
        pauseControlsUI.PauseControls.enabled = false;
        isPaused = false;
    }

    public void LoadSettings()
    {     
        settingsCanvas.enabled = true;
        pauseControlsUI.PauseControls.enabled = false;
    }

    public void ExitSettings()
    {
        settingsCanvas.enabled = false;
        pauseControlsUI.PauseControls.enabled = true;
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
        AudioListener.pause = false;
        Destroy(musicPlayer.gameObject);
    }
}
