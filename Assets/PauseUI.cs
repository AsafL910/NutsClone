using UnityEngine;

public class PauseUI : MonoBehaviour
{
    public GUISkin guiSkin;
    public float GuiScale = 0.3f;

    private Rect windowRect;

    void OnGUI()
    {
        if (!GameManager.Instance.isPaused) return;

        GUI.skin = guiSkin;

        float width = Screen.width * GuiScale;
        float height = Screen.height * GuiScale;

        float x = (Screen.width - width) / 2;
        float y = (Screen.height - height) / 2;

        windowRect = new Rect(x, y, width, height);

        windowRect = GUI.Window(0, windowRect, CreateWindow, "Pause");
    }

    void CreateWindow(int windowID)
    {
        float btnWidth = windowRect.width * 0.8f;
        float btnHeight = windowRect.height * 0.15f;
        float margin = windowRect.height * 0.03f;

        if (GUI.Button(new Rect((windowRect.width - btnWidth) / 2, margin * 10, btnWidth, btnHeight), "Resume")) {
            GameManager.Instance.isPaused = false;
            Time.timeScale = 1f;
        }

        if (GUI.Button(new Rect((windowRect.width - btnWidth) / 2, margin * 11 + btnHeight, btnWidth, btnHeight), "Restart")) {
            Time.timeScale = 1f;
            GameManager.Instance.Restart();
        }

        if (GUI.Button(new Rect((windowRect.width - btnWidth) / 2, margin * 12 + btnHeight * 2, btnWidth, btnHeight), "Quit")) {
            Application.Quit();
        }

        GUI.DragWindow(new Rect(0, 0, 10000, 10000));
    }
}