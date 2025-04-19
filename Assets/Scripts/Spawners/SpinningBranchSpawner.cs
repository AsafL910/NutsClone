using UnityEngine;

public class SpinningBranchSpawner : Spawner
{
    public GameObject obstaclePrefab;

    protected override void PerformSpawn(Transform spawnPoint)
    {
        Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.Euler(0, 90, 90));
    }
}
