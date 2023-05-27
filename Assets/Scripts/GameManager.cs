using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public float spawnInterval = 1.0f;
    public int playerHp = 3;

    void Start()
    {
        StartCoroutine(SpawnObjects());
    }

    void Update() {
        if (playerHp <= 0) {
            Debug.Log("Game Over!");
            //SceneManager.
        }
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
