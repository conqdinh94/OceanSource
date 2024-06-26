using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource musicSource; // AudioSource cho nhạc nền
    [SerializeField] private AudioSource SFXSource; // AudioSource cho âm thanh đặc biệt

    public AudioClip backgroundMusic; // AudioClip cho nhạc nền
    public AudioClip gameOverSound; // AudioClip cho âm thanh game over

    void Start()
    {
        PlayBackgroundMusic();
    }

    public void PlayBackgroundMusic()
    {
        if (musicSource != null && backgroundMusic != null)
        {
            musicSource.clip = backgroundMusic;
            musicSource.Play();
            musicSource.loop = true; // Đảm bảo nhạc nền lặp lại
        }
    }

    public void PlayGameOverSound()
    {
        if (musicSource != null && SFXSource != null && gameOverSound != null)
        {
            musicSource.Stop(); // Dừng nhạc nền
            SFXSource.clip = gameOverSound;
            SFXSource.Play();
        }
    }
}
