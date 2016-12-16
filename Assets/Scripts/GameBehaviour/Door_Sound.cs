using UnityEngine;
using System.Collections;

public class Door_Sound : MonoBehaviour {

    [SerializeField]AudioClip _door_audio;

    AudioPlayer _audioplayer;

    void Start()
    {
        _audioplayer = GameObject.FindObjectOfType<AudioPlayer>();
    }

	// Use this for initialization
	void PlayDoorAudio()
    {
        _audioplayer.PlayAudioOneShot(_door_audio,1f);
    }

}
