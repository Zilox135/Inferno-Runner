using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsUI : MonoBehaviour
{
    [SerializeField] Canvas controlsCanvas;
    [SerializeField] Canvas pauseControlsCanvas;
    [SerializeField] float displayDuration = 5f;

    public Canvas PauseControls
    {
        get { return pauseControlsCanvas; }
        set { pauseControlsCanvas = value; }
    }

    void Start()
    {
        pauseControlsCanvas.enabled = false;
        StartCoroutine(DisplayControls());
    }

    void Update()
    {
        TrackTutorial();
    }

    private void TrackTutorial()
    {
        if (!TutorialTracker.isCompleted)
        {
            controlsCanvas.enabled = true;
        }
        else
        {
            controlsCanvas.enabled = false;
        }
    }

    IEnumerator DisplayControls()
    {
        controlsCanvas.enabled = true;

        yield return new WaitForSeconds(displayDuration);
        controlsCanvas.enabled = false;
        TutorialTracker.isCompleted = true;
    }   
}
