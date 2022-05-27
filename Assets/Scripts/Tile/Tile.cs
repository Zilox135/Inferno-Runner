using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] float damage = 1f;
    [SerializeField] float damageDelay = 0.3f;
    private bool canDamage = true;
    PlayerHealth health;

    private void Awake() 
    {
        health = FindObjectOfType<PlayerHealth>();
    }

    private void OnCollisionStay(Collision tile)
    {
        if (canDamage && tile.gameObject.tag == "Player")
        {
            StartCoroutine(ProcessDamage());
        }
    }

    IEnumerator ProcessDamage()
    {
        canDamage = false;
        health.TakeDamage(damage);

        yield return new WaitForSeconds(damageDelay);
        canDamage = true;
    }
}
