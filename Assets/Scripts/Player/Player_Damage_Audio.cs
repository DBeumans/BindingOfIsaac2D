using UnityEngine;
using System.Collections;

public class Player_Damage_Audio : MonoBehaviour {

    AudioPlayer _audioPlayer;

    [SerializeField]AudioClip[] _player_damage_audio;

    void Start()
    {
        _audioPlayer = GameObject.FindObjectOfType<AudioPlayer>();
    }

    public void Play_Hit_Damage()
    {
        int randomSound = Random.Range(0, _player_damage_audio.Length);
        _audioPlayer.PlayAudioOneShot(_player_damage_audio[randomSound], 1f);
    }
}
