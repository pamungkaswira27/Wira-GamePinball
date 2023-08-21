using UnityEngine;

public class TriggerGameOver : MonoBehaviour
{
    public Collider bola;
    public GameObject gameOverCanvas;

    void OnTriggerEnter(Collider other)
    {
        if (other == bola)
        {
            gameOverCanvas.SetActive(true);
        }
    }
}
