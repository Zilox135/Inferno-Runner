using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    ScoreCounter scoreCounter;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI finalScoreText;
    
    private void Awake() 
    {
        scoreCounter = FindObjectOfType<ScoreCounter>();
    }

    void Update()
    {
        DisplayScore();
        DisplayFinalScore();
    }

    private void DisplayScore()
    {
        scoreText.text = scoreCounter.Score.ToString();
    }

    private void DisplayFinalScore()
    {
        finalScoreText.text = scoreCounter.Score.ToString();
    }
}
