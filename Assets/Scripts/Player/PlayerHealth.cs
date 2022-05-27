using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    [HideInInspector] public bool isDead = false;
    [HideInInspector] public float damage = 20f;
    [SerializeField] float hitPoints = 50f;
    [SerializeField] TextMeshProUGUI healthText;
    GameMenuLoader gameMenu;
    DeathHandler deathHandler;
    
    void Awake()
    {
        gameMenu = FindObjectOfType<GameMenuLoader>();
        deathHandler = GetComponent<DeathHandler>();
    }

    void Update()
    {
        Die();
        DisplayHealth();
    }

    public void TakeDamage(float damage)
    {   
        hitPoints -= damage;
    }

    private void Die()
    {
        if (hitPoints <= 0)
        {
            isDead = true;
            deathHandler.HandleDeath();
        }
    }

    private void DisplayHealth()
    {
        healthText.text = hitPoints.ToString();
    }
}
