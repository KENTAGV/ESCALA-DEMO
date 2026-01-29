using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    public AudioSource sfxSource;

    public AudioClip coin;
    public AudioClip hurt;
    public AudioClip step;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void PlayCoin()
    {
        sfxSource.PlayOneShot(coin);
    }

    public void PlayHurt()
    {
        sfxSource.PlayOneShot(hurt);
    }

    public void PlayStep()
    {
        sfxSource.PlayOneShot(step);
    }
}