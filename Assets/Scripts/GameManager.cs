using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int playerHp = 3;
    public float climbSpeed;

    public Spawner coinSpawner;
    public Spawner branchSpawner;

    void Start()
    {
        
    }

    void Update() {
        if (playerHp <= 0) {
            Debug.Log("Game Over!");
            //SceneManager.
        }
    }
}
