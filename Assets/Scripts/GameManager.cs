using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    public int playerHp = 3;
    public int totalCoins = 0;

    [Header("Speed Settings")]
    public float climbSpeed = 1f;
    public float speedIncreaseRate = 0.1f;
    public float maxClimbSpeed = 5f;

    public float totalDistance = 0f;
    void Start()
    {

    }

    void Update()
    {
        if (playerHp <= 0)
        {
            Debug.Log("Game Over!");
            //SceneManager...
        }

        totalDistance += climbSpeed * Time.deltaTime;

        speedIncreaseRate = Mathf.Max(totalDistance,100) / 1000;

        if (climbSpeed < maxClimbSpeed)
        {
            climbSpeed += speedIncreaseRate * Time.deltaTime;
            climbSpeed = Mathf.Min(climbSpeed, maxClimbSpeed);
        }
    }
}
