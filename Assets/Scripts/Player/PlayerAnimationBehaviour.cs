using UnityEngine;
using System.Collections;

public class PlayerAnimationBehaviour : MonoBehaviour {

    Animator _animator;
    InputBehaviour _inputBehaviour;
    Player_Health _player_Health;

    float _vertical;
    float _horizontal;
    bool _isDead;

    bool _left, _right, _up, _down;

    public bool ShootLeft { set { _left = value; } }
    public bool ShootRight { set { _right = value; } }
    public bool ShootUp { set { _up = value; } }
    public bool ShootDown { set { _down = value; } }

    void Start()
    {
        _animator = GetComponent<Animator>();
        _inputBehaviour = GameObject.FindObjectOfType<InputBehaviour>();
        _player_Health = GetComponentInParent<Player_Health>();
    }

    void Update()
    {
        _inputBehaviour.KeyCheck();
        Animation();
    }

    void Animation()
    {
        _horizontal = _inputBehaviour.Horizontal;
        _vertical = _inputBehaviour.Vertical;
        _isDead = _player_Health.IsDead;

        _animator.SetFloat("Vertical", _vertical);
        _animator.SetFloat("Horizontal", _horizontal);

        _animator.SetBool("IsMoving", true);

        _animator.SetBool("IsDead", _isDead);

        if (Mathf.Abs(_vertical) == 0 && Mathf.Abs(_horizontal) == 0)
        {
            _animator.SetBool("IsMoving", false);
        }


        if (_horizontal < 0) // left
            _animator.SetBool("Head_Left", true);
        if (_horizontal > 0) //right
            _animator.SetBool("Head_Right", true);
        if (_vertical < 0) // down
            _animator.SetBool("Head_Up", true);
        if (_vertical > 0)
            _animator.SetBool("Head_Down", true);

        else
        {
            _animator.SetBool("Head_Left", false); _animator.SetBool("Head_Up", false);_animator.SetBool("Head_Down", false);_animator.SetBool("Head_Right", false);
        }

    }
}
