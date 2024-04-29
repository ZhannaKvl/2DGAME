using UnityEngine;

public class Music : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip backgroundMusic;
    private bool isPlaying = false;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = backgroundMusic;
        PlayBackgroundMusic();
    }

    public void PlayBackgroundMusic()
    {
        if (!isPlaying)
        {
            audioSource.Play();
            isPlaying = true;
        }
    }

    public void StopBackgroundMusic()
    {
        if (isPlaying)
        {
            audioSource.Stop();
            isPlaying = false;
        }
    }
}
