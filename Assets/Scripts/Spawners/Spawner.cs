using System.Collections;
using UnityEngine;

public abstract class Spawner : MonoBehaviour
{
    [Tooltip("The vertical distance between each spawned element")]
    public float spawnDistance = 1.0f;
    public float rotationSpeed = 1f;

    private void Start()
    {
        StartCoroutine(SpawnLoop());
    }

    protected virtual IEnumerator SpawnLoop()
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
        PerformSpawn(spawnPoint);
    }
    protected abstract void PerformSpawn(Transform spawnPoint);
}
