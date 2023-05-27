using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public float spawnInterval = 1.0f;

    void Start()
    {
        StartCoroutine(SpawnObjects());
    }

    private IEnumerator SpawnObjects()
{
    while (true)
    {
        Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
        Debug.Log("Created branch");
        yield return new WaitForSeconds(spawnInterval);
    }
}
}