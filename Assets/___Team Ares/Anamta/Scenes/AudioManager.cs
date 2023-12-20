using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class AudioManager : MonoBehaviour
{
    public AudioClip audioClip1;
    public AudioClip audioClip2;

    private AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        // Play the first audio clip
        PlayAudioClip(audioClip1);
    }

    void Update()
    {
        // Check if the current audio clip is finished playing
        if (!audioSource.isPlaying)
        {
            // Play the next audio clip
            PlayAudioClip(audioClip2);
        }
    }

    void PlayAudioClip(AudioClip clip)
    {
        // Assign the new audio clip to the AudioSource
        audioSource.clip = clip;

        // Play the audio clip
        audioSource.Play();
    }
}
