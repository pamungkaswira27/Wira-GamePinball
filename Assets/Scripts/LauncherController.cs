using System.Collections;
using UnityEngine;

public class LauncherController : MonoBehaviour
{
    public Collider bola;
    public KeyCode input;

    public Material idleMaterial;
    public Material holdMaterial;

    public float maxTimeHold;
    public float maxForce;

    Renderer renderer;
    bool isHold;

    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    void OnCollisionStay(Collision collision)
    {
        if (collision.collider == bola)
        {
            ReadInput(bola);
        }
    }

    void ReadInput(Collider collider)
    {
        if (Input.GetKey(input) && !isHold)
        {
            StartCoroutine(StartHold(collider));
        }
    }

    IEnumerator StartHold(Collider collider)
    {
        isHold = true;
        renderer.material = holdMaterial;

        float force = 0f;
        float timeHold = 0f;

        while (Input.GetKey(input))
        {
            force = Mathf.Lerp(0f, maxForce, timeHold);
            yield return new WaitForEndOfFrame();
            timeHold += Time.deltaTime;
        }

        collider.GetComponent<Rigidbody>().AddForce(Vector3.forward * force);

        isHold = false;
        renderer.material = idleMaterial;
    }
}
