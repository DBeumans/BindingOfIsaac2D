﻿using UnityEngine;
using System.Collections;

public class Player_Bullet : MonoBehaviour {

    [SerializeField]
    float _bulletTravelSpeed = 2;
    int _bulletDamage = 1;

    public int BulletDamage { get { return _bulletDamage; } }

    [SerializeField]bool _left;
    [SerializeField]bool _right;
    [SerializeField]bool _up;
    [SerializeField]bool _down;
    string _direction;
    public string Direction
    {
        get { return _direction;  }
        set { _direction = value; }
    }

    BulletAnimationBehaviour _bulletAnimationBehaviour;
    Player_InputCheck _player_InputCheck;

    void Start()
    {
        _bulletAnimationBehaviour = GetComponent<BulletAnimationBehaviour>();
        _player_InputCheck = GameObject.FindObjectOfType<Player_InputCheck>();
    }
    void Update() { if (_bulletAnimationBehaviour.AnimationIsPlaying) { _bulletTravelSpeed = 0f; } }
    void FixedUpdate()
    {
        CheckDirection();
        Movement();        
    }

    void CheckDirection()
    {
        switch(_direction)
        {
            case "Left":
                _left = true;
                break;
            case "Right":
                _right = true;
                break;
            case "Up":
                _up = true;
                break;
            case "Down":
                _down = true;
                break;
        }
    }

    void Movement()
    {
            if (_left)
            { transform.Translate(Vector2.left *_bulletTravelSpeed * Time.deltaTime); }

            if (_right)
            { transform.Translate(Vector2.right   * _bulletTravelSpeed * Time.deltaTime); }

            if (_down)
            { transform.Translate(Vector2.down   * _bulletTravelSpeed * Time.deltaTime); }

            if (_up)
            { transform.Translate(Vector2.up   * _bulletTravelSpeed * Time.deltaTime); }
    }

}
