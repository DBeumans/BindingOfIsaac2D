using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {

    [SerializeField]
    protected float _bulletTravelSpeed = 2;
    [SerializeField]
    protected int _bulletDamage;

    public int BulletDamage { get { return _bulletDamage; } }

    [SerializeField]
    protected bool _left;
    [SerializeField]
    protected bool _right;
    [SerializeField]
    protected bool _up;
    [SerializeField]
    protected bool _down;
    protected string _direction;
    public string Direction
    {
        get { return _direction; }
        set { _direction = value; }
    }

    BulletAnimationBehaviour _bulletAnimationBehaviour;

    void Start()
    {
        _bulletAnimationBehaviour = GetComponent<BulletAnimationBehaviour>();
    }
    void Update() { if (_bulletAnimationBehaviour.AnimationIsPlaying) { _bulletTravelSpeed = 0f; } }
    void FixedUpdate()
    {
        CheckDirection();
        Movement();
    }

    void CheckDirection()
    {
        switch (_direction)
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
        { transform.Translate(Vector2.left * _bulletTravelSpeed * Time.deltaTime); }

        if (_right)
        { transform.Translate(Vector2.right * _bulletTravelSpeed * Time.deltaTime); }

        if (_down)
        { transform.Translate(Vector2.down * _bulletTravelSpeed * Time.deltaTime); }

        if (_up)
        { transform.Translate(Vector2.up * _bulletTravelSpeed * Time.deltaTime); }
    }
}
