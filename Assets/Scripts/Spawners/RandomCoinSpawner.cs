using UnityEngine;

public class RandomCoinSpawner : CoinSpawner
{
    protected override void Spawn()
    {
        Transform spawnPoint = transform;
        spawnPoint.RotateAround(Vector3.zero, Vector3.up, Random.Range(0,360));
        PerformSpawn(spawnPoint);
    }
}