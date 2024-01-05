using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public static AudioManager Instance { get; private set; }

    [SerializeField] private AudioSource sounds;
    [SerializeField] private AudioSource music;

    [Space]

    public AudioClip jump;
    public AudioClip throwBug;
    public AudioClip interfaceClick;
    public AudioClip win;
    public AudioClip gameOver;
    public AudioClip getBug;

    void Awake()
    {
        Instance = this;
    }


    public void PlaySound(AudioClip clip, float pitch = 1)
    {
        sounds.clip = clip;
        sounds.pitch = pitch;

        if (sounds.clip != null)
        {
            sounds.PlayOneShot(clip);
        }
    }
}
