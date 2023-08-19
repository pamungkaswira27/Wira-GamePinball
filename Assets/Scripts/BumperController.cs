using UnityEngine;

public class BumperController : MonoBehaviour
{
    public Collider bola;
    public float multiplier;
    public Color color;

    Animator animator;
    Renderer renderer;

    void Start()
    {
        animator = GetComponent<Animator>();
        renderer = GetComponent<Renderer>();

        renderer.material.color = color;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == bola)
        {
            Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
            bolaRig.velocity *= multiplier;

            // Animasi bumper
            animator.SetTrigger("hit");
        }
    }
}