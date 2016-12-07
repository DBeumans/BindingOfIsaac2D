using UnityEngine;
using System.Collections;

public class Enemy_Audio : MonoBehaviour {

    AudioPlayer _audioPlayer;

    [SerializeField]AudioClip _enemy_Death_Audio;

    void Start()
    {
        _audioPlayer = GameObject.FindObjectOfType<AudioPlayer>();
    }

    public void PlayAudio()
    {
        _audioPlayer.PlayAudioSound(_enemy_Death_Audio, false, 1f);
    }

}
