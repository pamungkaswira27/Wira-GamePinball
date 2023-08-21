using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CreditsUIController : MonoBehaviour
{
    public Button backButton;

    void OnEnable()
    {
        backButton.onClick.AddListener(BackToMenu);
    }

    void OnDisable()
    {
        backButton.onClick.RemoveListener(BackToMenu);
    }

    void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
