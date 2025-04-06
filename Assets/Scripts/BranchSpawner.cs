using UnityEngine;

public class BranchSpawner : Spawner
{
    public GameObject[] branchPrefabs;

    protected override void PerformSpawn(Transform spawnPoint)
    {
        var prefab = branchPrefabs[Random.Range(0, branchPrefabs.Length)];
        Vector3 spawnPos = spawnPoint.position + spawnOffset;
        Instantiate(prefab, spawnPos, Quaternion.Euler(spawnPoint.position));
    }
}