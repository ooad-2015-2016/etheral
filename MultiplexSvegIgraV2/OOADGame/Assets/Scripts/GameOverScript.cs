using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    public GUISkin skin;

    void Start()
    {
        skin = Resources.Load("GUISkin") as GUISkin;
    }

    void OnGUI()
    {
        const int buttonWidth = 120;
        const int buttonHeight = 60;

        GUI.skin = skin;

        GUI.Label(new Rect(
            Screen.width / 2 - (buttonWidth / 2),
            (1 * Screen.height / 2f) - (buttonHeight / 2),
            buttonWidth,
            buttonHeight), 
            "Score: " + TestScript.forGUI);

        // reset score for next game
        // TestScript.score = 0;

        if (
          GUI.Button(
            new Rect(
              Screen.width / 2 - (buttonWidth / 2),
              (1 * Screen.height / 3f) - (buttonHeight / 2),
              buttonWidth,
              buttonHeight
            ),
            "Retry"
          )
        )
        {
            // reload the level
            if (SceneManager.GetActiveScene().name == "scene_first")
                SceneManager.LoadScene("scene_first");
            else if (SceneManager.GetActiveScene().name == "scene_second")
                SceneManager.LoadScene("scene_second");

            TestScript.forGUI = 0;
        }

        if (
          GUI.Button(
            new Rect(
              Screen.width / 2 - (buttonWidth / 2),
              (2 * Screen.height / 3) - (buttonHeight / 2),
              buttonWidth,
              buttonHeight
            ),
            "Menu"
          )
        )
        {
            SceneManager.LoadScene("main_menu_scene");
            TestScript.forGUI = 0;
        }
    }
}