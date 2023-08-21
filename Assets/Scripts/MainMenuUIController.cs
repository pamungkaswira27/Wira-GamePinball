using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUIController : MonoBehaviour
{
    public Button playButton;
    public Button exitButton;
    public Button creditsButton;

    void OnEnable()
    {
        playButton.onClick.AddListener(PlayGame);
        exitButton.onClick.AddListener(ExitGame);
        creditsButton.onClick.AddListener(OpenCredits);
    }

    void OnDisable()
    {
        playButton.onClick.RemoveListener(PlayGame);
        exitButton.onClick.RemoveListener(ExitGame);
        creditsButton.onClick.RemoveListener(OpenCredits);
    }

    void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    void ExitGame()
    {
        Application.Quit();
    }

    void OpenCredits()
    {
        SceneManager.LoadScene("Credits");
    }
}
