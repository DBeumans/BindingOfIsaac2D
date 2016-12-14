using UnityEngine;
using System.Collections;

public class UI_ButtonSound : MonoBehaviour {

    AudioPlayer _audioPlayer;

    [SerializeField]
    AudioClip _buttonPressAudio;

    void Start()
    {
        _audioPlayer = GameObject.FindObjectOfType<AudioPlayer>();
    }

    public void PlayButtonSound()
    {
        _audioPlayer.PlayAudioOneShot(_buttonPressAudio, 1f);
    }

}
