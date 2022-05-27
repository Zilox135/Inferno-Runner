using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileCollision : MonoBehaviour
{
    [SerializeField] int scoreAmount;
    [SerializeField] float despawnDelay = 5f;
    ScoreCounter scoreCounter;
    
    private void Awake() 
    {
        scoreCounter = FindObjectOfType<ScoreCounter>();
    }
    
    private void Start() 
    {
        scoreAmount = scoreCounter.Score;
    }

    private void OnCollisionExit(Collision tile) 
    {
        if (tile.gameObject.tag == "Player")
        {
            scoreCounter.IncreaseScore(scoreCounter.ScoreAmount);
            Destroy(gameObject, despawnDelay);
        }
    }
}
