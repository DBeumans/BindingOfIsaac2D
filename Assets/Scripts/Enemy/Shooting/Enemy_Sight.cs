using UnityEngine;
using System.Collections;

public class Enemy_Sight : MonoBehaviour {

    Enemy_Shooting _enemy_Shooting;

    bool _playerInSight;
    bool _left, _right, _up, _down;
    public bool PlayerInSight { get { return _playerInSight; } }

    void Start()
    {
        _enemy_Shooting = GameObject.FindObjectOfType<Enemy_Shooting>();
    }

    void Update()
    {
        if(_playerInSight)
        {
            if (_left)
            {
                Debug.Log("Left");
                _enemy_Shooting.Shoot("Left");
            }
            if (_right)
            {
                _enemy_Shooting.Shoot("Right");
            }
            if (_up)
            {
                _enemy_Shooting.Shoot("Up");
            }
            if (_down)
            {
                _enemy_Shooting.Shoot("Down");
            }
        }
    }
    
    void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player" && other.gameObject.name == "Player")
        {
            if(this.gameObject.name == "Sight_Left") // left
            {
                _playerInSight = true;
                _left = true;          
            }
            if(this.gameObject.name == "Sight_Right") // right
            {
                _playerInSight = true;
                _right = true;
            }
            if(this.gameObject.name == "Sight_Up") // up
            {
                _playerInSight = true;
                _up = true;
            }
            if(this.gameObject.name == "Sight_Down") // Down
            {
                _playerInSight = true;
                _down = true;
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        _playerInSight = false;
        _left = false;_right = false;_up = false; _down = false;
    }
}
