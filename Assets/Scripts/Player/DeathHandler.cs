using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathHandler : MonoBehaviour
{
    [SerializeField] Canvas deathCanvas;
    [SerializeField] Canvas healthCanvas;
    [SerializeField] Canvas scoreCanvas;
    private GameMenuLoader menuLoader;
    
    private void Awake() 
    {
        menuLoader = FindObjectOfType<GameMenuLoader>();
    }
    
    private void Start() 
    {
        deathCanvas.enabled = false;
    }
    
    public void HandleDeath()
    {
        if (!menuLoader.IsPaused)
        {
            deathCanvas.enabled = true;
        }

        healthCanvas.enabled = false;
        scoreCanvas.enabled = false;        
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true; 
    }
}
