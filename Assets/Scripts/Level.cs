using System.Collections;
using UnityEngine;

public class Level : MonoBehaviour
{
    public float totalDistance;
    public Spawner obstacleSpawner;
    public Spawner coinSpawner;
    public float levelGapDistance = 5f;
    void Start()
    {
        StartCoroutine(InitSpawners());
    }

    private IEnumerator InitSpawners()
    {
        yield return new WaitForSeconds(levelGapDistance / GameManager.Instance.climbSpeed);
        Instantiate(obstacleSpawner.gameObject, transform);
        Instantiate(coinSpawner.gameObject, transform);
    }
}
