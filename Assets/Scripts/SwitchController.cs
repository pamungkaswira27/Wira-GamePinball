using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SwitchController : MonoBehaviour
{
    enum SwitchState
    {
        Off,
        On,
        Blink
    }

    public Collider bola;
    public Material onMaterial;
    public Material offMaterial;

    public AudioManager audioManager;
    public VFXManager vfxManager;

    Renderer renderer;
    SwitchState state;

    void Start()
    {
        renderer = GetComponent<Renderer>();

        Set(false);

        StartCoroutine(BlinkTimerStart(5f));
    }

    void OnTriggerEnter(Collider other)
    {
        if (other == bola)
        {
            Toggle();
            vfxManager.PlaySwitchVFX(transform.position);
        }
    }

    void Set(bool active)
    {
        if (active)
        {
            state = SwitchState.On;
            renderer.material = onMaterial;
            StopAllCoroutines();
        }
        else
        {
            state = SwitchState.Off;
            renderer.material = offMaterial;
            StartCoroutine(BlinkTimerStart(5f));
        }
    }

    void Toggle()
    {
        if (state == SwitchState.On)
        {
            Set(false);
            audioManager.PlaySwitchOffSFX(transform.position);
        }
        else
        {
            Set(true);
            audioManager.PlaySwitchOnSFX(transform.position);
        }
    }

    IEnumerator Blink(int blinkTimes)
    {
        state = SwitchState.Blink;

        for (int i = 0; i <  blinkTimes; i++)
        {
            renderer.material = onMaterial;
            yield return new WaitForSeconds(0.5f);
            renderer.material = offMaterial;
            yield return new WaitForSeconds(0.5f);
        }

        state = SwitchState.Off;

        StartCoroutine(BlinkTimerStart(5f));
    }

    IEnumerator BlinkTimerStart(float time)
    {
        yield return new WaitForSeconds(time);
        StartCoroutine(Blink(2));
    }
}
