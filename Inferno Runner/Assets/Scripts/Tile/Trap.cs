using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    [SerializeField] float damage = 20f;
    PlayerHealth health;
    
    private void Awake() 
    {
        health = FindObjectOfType<PlayerHealth>();
    }

    private void Start() 
    {
        damage = health.damage;
    }
    
    private void OnCollisionEnter(Collision trap) 
    {
        if (trap.gameObject.tag == "Player")
        {
            ProcessDamage();
        }
    }

    private void ProcessDamage()
    {
        health.TakeDamage(damage);
    }
}
