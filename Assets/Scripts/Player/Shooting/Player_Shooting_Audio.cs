using UnityEngine;
using System.Collections;

public class Player_Shooting_Audio : MonoBehaviour {

    AudioPlayer _audioPlayer;

    [SerializeField]AudioClip _audioClip;

    void Awake()
    {
        _audioPlayer = GameObject.FindObjectOfType<AudioPlayer>();
    }

    public void Audio()
    {
        _audioPlayer.PlayAudioSound(_audioClip,false,1f);
    }
}
