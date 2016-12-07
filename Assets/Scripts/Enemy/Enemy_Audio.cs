using UnityEngine;
using System.Collections;

public class Enemy_Audio : MonoBehaviour {

    AudioPlayer _audioPlayer;

    [SerializeField]AudioClip[] _enemy_Death_Audio;


    void Start()
    {
        _audioPlayer = GameObject.FindObjectOfType<AudioPlayer>();
    }

    public void PlayAudio()
    {
        int _audioClip = Random.Range(0, _enemy_Death_Audio.Length);
        Debug.Log(_audioClip);
        _audioPlayer.PlayAudioSound(_enemy_Death_Audio[_audioClip], false, 1f);
    }

}
