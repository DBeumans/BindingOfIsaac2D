using UnityEngine;
using System.Collections;

public class AudioPlayer : MonoBehaviour
{
    AudioSource _audioSource;

    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }
    public void PlayAudioSound(AudioClip audioClip, bool loop, float volume)
    {
        /*
        _audioSource.volume = volume;
        _audioSource.loop = loop;
        _audioSource.clip = audioClip;
        */    
        _audioSource.PlayOneShot(audioClip,volume);
    }
}
