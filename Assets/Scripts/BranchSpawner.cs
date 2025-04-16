using UnityEngine;

public class BranchSpawner : Spawner
{
    public GameObject[] branchPrefabs;

    protected override void PerformSpawn(Transform spawnPoint)
    {
        var prefab = branchPrefabs[Random.Range(0, branchPrefabs.Length)];
        Vector3 spawnPos = spawnPoint.position + spawnOffset;
        float yDegree = Random.Range(0, 360);
        Instantiate(prefab, spawnPos, Quaternion.Euler(0, yDegree, 90));
    }
}