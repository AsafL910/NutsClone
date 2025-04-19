using UnityEngine;

public class SpinningBranchSpawner : Spawner
{
    public GameObject obstaclePrefab;
    protected override void Spawn()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        Transform spawnPoint = transform;
        PerformSpawn(spawnPoint);
    }
    protected override void PerformSpawn(Transform spawnPoint)
    {
        Instantiate(obstaclePrefab, spawnPoint.position, transform.rotation * Quaternion.Euler(0,90,90));
    }
}
