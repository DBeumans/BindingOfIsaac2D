using UnityEngine;
using System.Collections;

public class AudioPlayer : MonoBehaviour
{
    AudioSource _audioSource;

    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }
    public void PlayAudioSound(AudioClip audio)
    {
        _audioSource.PlayOneShot(audio);
    }
}
