using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    [Header("Audio Source")]
    public AudioSource audioSource;

    [Header("Clips")]
    public AudioClip hurt;
    public AudioClip coin;
    public AudioClip step;

    void Awake()
    {
        // Singleton
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlayHurt()
    {
        audioSource.PlayOneShot(hurt);
    }

    public void PlayCoin()
    {
        audioSource.PlayOneShot(coin);
    }

    public void PlayStep()
    {
        audioSource.PlayOneShot(step);
    }
}

