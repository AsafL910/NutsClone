using System.Collections;
using UnityEngine;

public abstract class Spawner : MonoBehaviour
{
    [Tooltip("The vertical distance between each spawned element")]
    public float spawnDistance = 1.0f;

    [Tooltip("Where to spawn relative to this gameObject")]
    public Vector3 spawnOffset;
    public float rotationSpeed = 1f;

    protected virtual void Start()
    {
        StartCoroutine(SpawnLoop());
    }

    private IEnumerator SpawnLoop()
    {
        while (true)
        {
            Spawn();
            yield return new WaitForSeconds(spawnDistance / GameManager.Instance.climbSpeed);
        }
    }

    protected virtual void Spawn()
    {
        Transform spawnPoint = transform;
        spawnPoint.RotateAround(Vector3.zero, Vector3.up, rotationSpeed * Time.deltaTime);
        Debug.Log("Spawned branch ");
        PerformSpawn(spawnPoint);
    }
    protected abstract void PerformSpawn(Transform spawnPoint);
}
