using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }
    public int playerHp = 3;

    [Header("Speed Settings")]
    public float climbSpeed = 1f;
    public float speedIncreaseRate = 0.1f; // Speed added per second
    public float maxClimbSpeed = 5f;

    public float totalDistance = 0f;

    [Header("Spawners")]
    public Spawner coinSpawner;
    public Spawner branchSpawner;

    void Start()
    {

    }

    void Update()
    {
        if (playerHp <= 0)
        {
            Debug.Log("Game Over!");
            //SceneManager.
        }

        totalDistance += climbSpeed * Time.deltaTime;
        Debug.Log("Distance Traveled: " + totalDistance);

        if (climbSpeed < maxClimbSpeed)
        {
            climbSpeed += speedIncreaseRate * Time.deltaTime;
            climbSpeed = Mathf.Min(climbSpeed, maxClimbSpeed); // clamp it
        }
    }
}
