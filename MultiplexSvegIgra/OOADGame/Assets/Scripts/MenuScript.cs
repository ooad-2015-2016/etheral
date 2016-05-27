using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public GUISkin skin;

    void Start()
    {
        skin = Resources.Load("GUISkin") as GUISkin;
    }

    void OnGUI()
    {
        const int buttonWidth = 200;
        const int buttonHeight = 70;

        GUI.skin = skin;
        Rect buttonRectFirst = new Rect(
              Screen.width / 2 - (buttonWidth / 2),
              (2 * Screen.height / 5) - (buttonHeight / 2),
              buttonWidth,
              buttonHeight
            );

        Rect buttonRectSecond = new Rect(
              Screen.width / 2 - (buttonWidth / 2),
              (2 * Screen.height / 4f) - (buttonHeight / 2),
              buttonWidth,
              buttonHeight
            );

        if (GUI.Button(buttonRectFirst, "Captain America: Civil War"))
        {
            SceneManager.LoadScene("scene_first");
        }
        else if (GUI.Button(buttonRectSecond, "Star Wars The Force Awakens"))
        {
            SceneManager.LoadScene("scene_second");
        }
        else if (GUI.Button(new Rect(Screen.width / 2 - (buttonWidth / 2), (2 * Screen.height / 2.5f) - (buttonHeight / 2.6f), buttonWidth, buttonHeight / 2), "Quit Game"))
        {
            Application.Quit();
        }
    }
}
