using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    void OnGUI()
    {
        const int buttonWidth = 120;
        const int buttonHeight = 60;

        if (
          GUI.Button(
            new Rect(
              Screen.width / 2 - (buttonWidth / 2),
              (1 * Screen.height / 3) - (buttonHeight / 2),
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
        }
    }
}