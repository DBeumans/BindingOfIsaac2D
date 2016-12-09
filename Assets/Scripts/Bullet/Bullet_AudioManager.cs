using UnityEngine;
using System.Collections;

public class Bullet_AudioManager : MonoBehaviour {

    /*
    This script does NOT play the audio files.
    */

    AudioPlayer _audioPlayer;

    [SerializeField]AudioClip[] _audioClips;
    AudioClip _audioClip;

    void Awake()
    {
        _audioPlayer = GameObject.FindObjectOfType<AudioPlayer>();
    }

    public void Audio(string _audio)
    {
        switch(_audio)
        {
            case "Bullet_Hit_Ground":
                _audioClip = _audioClips[0];
                _audioPlayer.PlayAudioSound(_audioClip,false,1f);
                break;
            case "Bullet_Hit_Wall":
                _audioClip = _audioClips[1];
                _audioPlayer.PlayAudioSound(_audioClip,false,1f);
                break;
        }
    }
}
