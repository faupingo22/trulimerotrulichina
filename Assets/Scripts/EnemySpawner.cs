using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 3f;
    public float spawnRangeX = 5f;
    public float spawnDistance = 60f;

    private void Start()
    {
        InvokeRepeating("SpawnEnemy", 3f, spawnInterval);
    }

    void SpawnEnemy()
    {
        float randomX = Random.Range(-spawnRangeX, spawnRangeX);
        Vector3 spawnPos = new Vector3(randomX, 0, transform.position.z + spawnDistance);
        Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
    }
}