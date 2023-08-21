using UnityEngine;

public class VFXManager : MonoBehaviour
{
    public GameObject bumperVfxPrefab;
    public GameObject switchVfxPrefab;

    public void PlayBumperVFX(Vector3 spawnPosition)
    {
        Instantiate(bumperVfxPrefab, spawnPosition, Quaternion.identity);
    }

    public void PlaySwitchVFX(Vector3 spawnPosition)
    {
        Instantiate(switchVfxPrefab, spawnPosition, Quaternion.identity);
    }
}
