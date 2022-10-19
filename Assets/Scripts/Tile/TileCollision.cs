using UnityEngine;

public class TileCollision : MonoBehaviour
{
    [SerializeField] private float despawnDelay = 5f;
    private ScoreCounter scoreCounter;
    private bool hasCollided = false;
    
    private void Awake() 
    {
        scoreCounter = FindObjectOfType<ScoreCounter>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (gameObject.CompareTag("Start")) return;
        
        if (collision.gameObject.CompareTag("Player") && !hasCollided)
        {
            scoreCounter.IncreaseScore(scoreCounter.ScoreAmount);
            hasCollided = true; 
            Destroy(gameObject, despawnDelay);
        }
    }
}
