using UnityEngine;

public class Sound : MonoBehaviour
{
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.enabled = false;
    }

    public void PlayBonk()
    {
        audioSource.enabled = true;
    }

    public void StopBonk()
    {
        audioSource.enabled = false;
    }
}
