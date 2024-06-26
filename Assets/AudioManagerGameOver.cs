 using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AudioManagerGameOver : MonoBehaviour
{

    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    public AudioClip gameOver;

    public void Start()
    {
        musicSource.clip = gameOver;
        musicSource.Play();
    }
}
