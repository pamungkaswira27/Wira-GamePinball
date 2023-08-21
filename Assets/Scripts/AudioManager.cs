using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource bgmAudioSource;
    public GameObject bumperSfxAudioSource;
    public GameObject switchOnSfxAudioSource;
    public GameObject switchOffSfxAudioSource;

    void Start()
    {
        PlayBGM();
    }

    void PlayBGM()
    {
        bgmAudioSource.Play();
    }

    public void PlayBumperSFX(Vector3 spawnPosition)
    {
        Instantiate(bumperSfxAudioSource, spawnPosition, Quaternion.identity);
    }

    public void PlaySwitchOnSFX(Vector3 spawnPosition)
    {
        Instantiate(switchOnSfxAudioSource, spawnPosition, Quaternion.identity);
    }

    public void PlaySwitchOffSFX(Vector3 spawnPosition)
    {
        Instantiate(switchOffSfxAudioSource, spawnPosition, Quaternion.identity);
    }
}
