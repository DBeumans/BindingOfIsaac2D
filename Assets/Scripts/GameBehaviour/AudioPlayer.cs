using UnityEngine;
using System.Collections;

public class AudioPlayer : MonoBehaviour
{
    AudioSource _audioSource;

    void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }
    
    public void PlayAudioOneShot(AudioClip audioClip, float volume)
    {
        _audioSource.PlayOneShot(audioClip, volume);
    }

    public void PlayAudioSounds(AudioClip _audioClip, bool _loop, float _volume)
    {
        
        _audioSource.volume = _volume;
        _audioSource.loop = _loop;
        _audioSource.clip = _audioClip;
        _audioSource.Play();
        
    }
}
