using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public GameObject obstaclePrefab;
    public float spawnInterval = 1.0f;
    public Vector3 spawnOffset;
    public float angle = 10;
    public float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnObjects());
    }

    private IEnumerator SpawnObjects()
{
    while (true)
    {
        Transform spawnPoint = transform;
        spawnPoint.RotateAround(Vector3.zero ,Vector3.up, rotationSpeed * Time.deltaTime * angle);
        Instantiate(prefabToSpawn, spawnPoint.position + spawnOffset, Quaternion.Euler(0,90,90));
        GameObject obstacle = Instantiate(obstaclePrefab, spawnOffset, Quaternion.Euler(spawnPoint.position));
        yield return new WaitForSeconds(spawnInterval);
    }
}
}
