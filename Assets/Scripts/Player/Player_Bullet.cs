using UnityEngine;
using System.Collections;

public class Player_Bullet : MonoBehaviour {

    [SerializeField]
    float _bulletTravelSpeed = 2;

    [SerializeField]bool _left;
    [SerializeField]bool _right;
    [SerializeField]bool _up;
    [SerializeField]bool _down;

    public string Direction;

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
        switch(Direction)
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
