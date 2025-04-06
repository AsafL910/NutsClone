using UnityEngine;

public class CoinSpawner : Spawner
{
    public GameObject coinPrefab;

    protected override void PerformSpawn(Transform spawnPoint)
    {
        Instantiate(coinPrefab, spawnPoint.position + spawnOffset, Quaternion.Euler(0, 90, 90));
    }
}
