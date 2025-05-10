using UnityEngine;
using UnityEngine.SceneManagement;

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
    public bool isPaused = false;

    [Header("Speed Settings")]
    public float climbSpeed = 1f;
    public float speedIncreaseRate = 0.1f;
    public float maxClimbSpeed = 5f;
    public float totalDistance = 0f;

    public void Pause()
    {
        isPaused = true;
        Time.timeScale = 0f;
    }
    public void UnPause()
    {
        isPaused = false;
        Time.timeScale = 1f;
    }
    
    void Start()
    {

    }

    void Update()
    {
        if (playerHp <= 0)
        {
            Debug.Log("Game Over!");
            //SceneManager... restart in delay
        }

        Time.timeScale = isPaused ? 0f : 1f; //TODO: make sure it is not interfering with slow motion/Speed boost

        totalDistance += climbSpeed * Time.deltaTime;

        speedIncreaseRate = Mathf.Max(totalDistance,100) / 1000;

        if (climbSpeed < maxClimbSpeed)
        {
            climbSpeed += speedIncreaseRate * Time.deltaTime;
            climbSpeed = Mathf.Min(climbSpeed, maxClimbSpeed);
        }
    }

    public void Restart() {
        totalDistance = 0;
        totalCoins = 0;
        climbSpeed = 1;
        playerHp = 3;
        isPaused = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
