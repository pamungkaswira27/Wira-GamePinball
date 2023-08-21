using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public float score;

    void Start()
    {
        ResetScore();
    }

    public void AddScore(float addition)
    {
        score += addition;
    }

    public void ResetScore()
    {
        score = 0f;
    }
}
