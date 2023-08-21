using UnityEngine;

public class TriggerZoomOutController : MonoBehaviour
{
    public Collider bola;
    public CameraController cameraController;

    void OnTriggerEnter(Collider other)
    {
        if (other == bola)
        {
            cameraController.GoBackToDefault();
        }
    }
}
