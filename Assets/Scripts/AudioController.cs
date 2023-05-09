using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{
    public AudioClip[] audioClips; // an array of audio clips
    private AudioSource audioSource;
    public Button[] playButtons; // an array of play buttons
    public Button stopButton; // the stop button

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();

        for (int i = 0; i < playButtons.Length; i++)
        {
            int clipIndex = i; 
            playButtons[i].onClick.AddListener(() => PlayAudioClip(clipIndex));
        }

        stopButton.onClick.AddListener(StopAudioClip);
    }

    private void PlayAudioClip(int clipIndex)
    {
        // play the audio clip 
        if (clipIndex < audioClips.Length)
        {
            audioSource.clip = audioClips[clipIndex];
            audioSource.Play();
        }
    }

    private void StopAudioClip()
    {
        // stop the audio clip
        audioSource.Stop();
    }
}

