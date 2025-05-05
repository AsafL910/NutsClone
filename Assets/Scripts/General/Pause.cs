using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject pauseMenuUI;

    public void TogglePause()
    {
        bool isPaused = Time.timeScale == 0f;

        Time.timeScale = isPaused ? 1f : 0f;

        if (pauseMenuUI != null)
            pauseMenuUI.SetActive(!isPaused);
    }
}
