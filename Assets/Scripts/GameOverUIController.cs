using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverUIController : MonoBehaviour
{
    public Button mainMenuButton;

    void OnEnable()
    {
        mainMenuButton.onClick.AddListener(BackToMainMenu);
    }

    void OnDisable()
    {
        mainMenuButton.onClick.RemoveListener(BackToMainMenu);
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
