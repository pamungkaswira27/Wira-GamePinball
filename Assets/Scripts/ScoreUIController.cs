using TMPro;
using UnityEngine;

public class ScoreUIController : MonoBehaviour
{
    public TMP_Text scoreText;

    public ScoreManager scoreManager;

    void Update()
    {
        scoreText.text = scoreManager.score.ToString();
    }
}
