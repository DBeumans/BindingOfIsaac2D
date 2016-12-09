using UnityEngine;
using System.Collections;

public class Enemy_FX : MonoBehaviour {
	// naam geving.
    [SerializeField]
    GameObject[] _blood_Paddle;

    Transform _position;
    void Instantiate_FX()
    {
        _position = this.gameObject.transform;
        int randomFX = Random.Range(0, _blood_Paddle.Length);
        GameObject paddle = (GameObject)Instantiate(_blood_Paddle[randomFX]) as GameObject;
        paddle.transform.position = _position.position;
    }
}
