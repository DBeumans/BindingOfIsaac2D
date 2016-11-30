using UnityEngine;
using System.Collections;

public class Tags : MonoBehaviour {


    string _player = "Player";
    string _wall = "Wall";
    string _ground = "Ground";
    string _enemy = "Enemy";

    public string Player { get { return _player; } }
    public string Wall { get { return _wall; } }
    public string Ground { get { return _ground; } }
    public string Enemy { get { return _enemy; } }
}
