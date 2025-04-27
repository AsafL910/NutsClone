using System.Collections;
using UnityEngine;

public class SpinningBranchSpawner : CoinSpawner
{
    public GameObject obstaclePrefab;
    public int minObstaclesPerDirection = 10;
    public int maxObstaclesPerDirection = 20;
    public float coinOffset = 0.5f;
    private int maxObstaclesForCurrentDirection = 0;
    private int obstaclesSpawned = 0;
    private int direction = 1;

    void Update()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime * direction);
    }

    protected override IEnumerator SpawnLoop()
    {
        while (true)
        {
            Spawn();
            if (obstaclesSpawned > maxObstaclesForCurrentDirection) {
                maxObstaclesForCurrentDirection = Random.Range(minObstaclesPerDirection,maxObstaclesPerDirection);
                direction *= -1;
                obstaclesSpawned = 0;
            }
            yield return new WaitForSeconds(spawnDistance / GameManager.Instance.climbSpeed);
        }
    }
    protected override void Spawn()
    {
        Transform spawnPoint = transform;
        PerformSpawn(spawnPoint);
        obstaclesSpawned++;
    }
    protected override void PerformSpawn(Transform spawnPoint)
    {
        Instantiate(obstaclePrefab, spawnPoint.position, transform.rotation * Quaternion.Euler(0, 90, 90));
        
        Vector3 offset = spawnPoint.right * coinOffset;

        Instantiate(coinPrefab, spawnPoint.position + offset, transform.rotation * Quaternion.identity);
    }
}
