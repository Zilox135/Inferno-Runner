using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    private int score = 0;
    private int scoreAmount = 20;

    public int Score
    {
        get { return score; }
        set { score = value; }
    }

    public int ScoreAmount
    {
        get { return scoreAmount; }
        set { scoreAmount = value; }
    }

    public void IncreaseScore(int scoreAmount)
    {
        score += scoreAmount;
    }
}
