using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public Level[] levels;
    private Level currentLevel {get; set;}
    private float levelDistanceTraveled = 0f;

    void Start()
    {
        currentLevel = Instantiate(levels[0], transform.position, Quaternion.identity);
    }
    void Update()
    {
        levelDistanceTraveled += GameManager.Instance.climbSpeed * Time.deltaTime;

        if (levelDistanceTraveled > currentLevel.totalDistance) {
            Level newLevel = levels[Random.Range(0,levels.Length)];
            
            while (currentLevel.name.Contains(newLevel.name)) {
                newLevel = levels[Random.Range(0,levels.Length)];
            }

            levelDistanceTraveled = 0f;
            Destroy(currentLevel.gameObject);
            Level levelPrefab = Instantiate(newLevel, transform.position, Quaternion.identity);
            currentLevel = levelPrefab;
        }
    }
}
