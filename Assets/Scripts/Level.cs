using UnityEngine;

public class Level : MonoBehaviour
{
    public float totalDistance;
    public Spawner obstacleSpawner;
    public Spawner coinSpawner;
    void Start()
    {
        Instantiate(obstacleSpawner.gameObject, transform);
        Instantiate(coinSpawner.gameObject, transform);
    }
}
