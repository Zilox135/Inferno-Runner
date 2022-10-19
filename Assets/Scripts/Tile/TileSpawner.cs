using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] tiles;
    [SerializeField] float spawnDelay = 5f;
    [SerializeField] float updateDelay = 5f;
    [SerializeField] float timeBeforeSpawn = 0f;
    [SerializeField] float minRangeX = -10f;
    [SerializeField] float maxRangeX = 10f;
    [SerializeField] float minRangeY = -10f;
    [SerializeField] float maxRangeY = 10f;
    [SerializeField] float increaseRange = 20f;
    private bool canSpawn = true;
    
    private void Awake() 
    {
        InvokeRepeating("StartSpawn", timeBeforeSpawn, updateDelay);
    }
    
    private void StartSpawn() 
    {
        if (canSpawn)
        {
            StartCoroutine(SpawnTile());
        }
    }

    IEnumerator SpawnTile()
    {
        canSpawn = false;
        for (int i = 0; i < tiles.LongLength; i++)
        {
            float randomRangeX = Random.Range(minRangeX, maxRangeX);
            float randomRangeY = Random.Range(minRangeY, maxRangeY);
            Vector3 randomPosition = new Vector3(randomRangeX, randomRangeY, 0);

            int spawnerID = Random.Range(0, tiles.Length);
            Instantiate(tiles[spawnerID], randomPosition, Quaternion.identity);

            yield return new WaitForSeconds(spawnDelay);
            minRangeX -= increaseRange;
            maxRangeX -= increaseRange;
            canSpawn = true;     
        }
    }
}
