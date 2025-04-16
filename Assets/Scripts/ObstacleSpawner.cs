using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float spawnInterval = 2f;
    public float spawnRangeX = 5f;
    public float spawnDistance = 50f;

    private void Start()
    {
        InvokeRepeating("SpawnObstacle", 2f, spawnInterval);
    }

    void SpawnObstacle()
    {
        float randomX = Random.Range(-spawnRangeX, spawnRangeX);
        Vector3 spawnPos = new Vector3(randomX, 0, transform.position.z + spawnDistance);
        Instantiate(obstaclePrefab, spawnPos, Quaternion.identity);
    }
}