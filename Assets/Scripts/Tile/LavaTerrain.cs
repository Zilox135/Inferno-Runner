using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaTerrain : MonoBehaviour
{
    [SerializeField] float damage = 30f;
    [SerializeField] Vector3 force;             
    PlayerHealth health;
    
    private void Awake()
    {
        health = FindObjectOfType<PlayerHealth>();     
    }

    private void Update() 
    {
        transform.Translate(force * Time.deltaTime, Space.World);
    }

    private void OnCollisionStay(Collision self) 
    {
        health.TakeDamage(damage);
    }
}
