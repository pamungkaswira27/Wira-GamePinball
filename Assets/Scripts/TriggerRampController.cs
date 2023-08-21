using UnityEngine;

public class TriggerRampController : MonoBehaviour
{
    public Collider bola;
    public ScoreManager scoreManager;
    public float score;

    void OnTriggerEnter(Collider other)
    {
        if (other ==  bola)
        {
            scoreManager.AddScore(score);
        }
    }
}
