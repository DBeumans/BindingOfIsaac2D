using UnityEngine;
using System.Collections;

public class Player_Movement_Animation : MonoBehaviour {

    Animator _animator;
    InputBehaviour _inputBehaviour;

    float _vertical;
    float _horizontal;

    bool _left, _right, _up, _down;

    public bool ShootLeft { set { _left = value; } }
    public bool ShootRight { set { _right = value; } }
    public bool ShootUp { set { _up = value; } }
    public bool ShootDown { set { _down = value; } }

    void Start()
    {
        _animator = GetComponent<Animator>();
        _inputBehaviour = GameObject.FindObjectOfType<InputBehaviour>();
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

        _animator.SetFloat("WalkVertical",  _vertical );
        _animator.SetFloat("WalkHorizontal", _horizontal);
        _animator.SetBool("PlayerMoving", true);

        _animator.SetBool("Player_Shoot_Left",_left);
        _animator.SetBool("Player_Shoot_Right", _right);
        _animator.SetBool("Player_Shoot_Up", _up);
        _animator.SetBool("Player_Shoot_Down", _down);

        if(Mathf.Abs(_vertical) ==0 && Mathf.Abs(_horizontal ) == 0)
        {
            _animator.SetBool("PlayerMoving", false);
        }
    }
}
