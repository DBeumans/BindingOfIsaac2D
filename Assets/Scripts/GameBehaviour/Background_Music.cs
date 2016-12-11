using UnityEngine;
using System.Collections;

public class Background_Music : MonoBehaviour {

    [SerializeField]AudioClip _song;
    AudioPlayer _audioPlayer;
    void Start()
    {
        _audioPlayer = GameObject.FindObjectOfType<AudioPlayer>();
        _audioPlayer.PlayAudioSounds(_song, true, .2f);
    }

}
