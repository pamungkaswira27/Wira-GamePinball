using UnityEngine;

public class TriggerZoomInController : MonoBehaviour
{
    public Collider bola;
    public CameraController cameraController;
    public float length;

    void OnTriggerEnter(Collider other)
    {
        if (other ==  bola)
        {
            cameraController.FollowTarget(bola.transform, length);
        }
    }
}
