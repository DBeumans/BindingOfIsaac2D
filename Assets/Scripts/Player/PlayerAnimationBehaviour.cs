﻿using UnityEngine;
using System.Collections;

public class PlayerAnimationBehaviour : MonoBehaviour {

    Animator _animator;
    InputBehaviour _inputBehaviour;
    Player_Health _player_Health;

    float _vertical;
    float _horizontal;
    bool _isDead;
    bool _getDamage;
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
        _getDamage = _player_Health.RecieveDamage;

        _animator.SetFloat("Vertical", _vertical);
        _animator.SetFloat("Horizontal", _horizontal);

        _animator.SetBool("IsMoving", true);
        _animator.SetBool("GetDamage", _getDamage);

        if (_isDead)
        {
            _animator.SetLayerWeight(1, 0f);
            _animator.SetLayerWeight(2, 0f);
            _animator.SetBool("IsDead", _isDead);

        }

        if (Mathf.Abs(_vertical) == 0 && Mathf.Abs(_horizontal) == 0)
        {
            _animator.SetBool("IsMoving", false);
        }

        if (_inputBehaviour.ArrowLeft && !_animator.GetCurrentAnimatorStateInfo(2).IsName("Left"))
        { // left
            _animator.SetTrigger("Shoot_Left");
            _animator.SetBool("Not_Shooting", false);
        }
        if (_inputBehaviour.ArrowRight && !_animator.GetCurrentAnimatorStateInfo(2).IsName("Right")) //right
        {
            _animator.SetTrigger("Shoot_Right");
            _animator.SetBool("Not_Shooting", false);
        }
            
        if (_inputBehaviour.ArrowDown && !_animator.GetCurrentAnimatorStateInfo(2).IsName("Down")) // down
        {
            _animator.SetTrigger("Shoot_Down");
            _animator.SetBool("Not_Shooting", false);
        }
            
        if (_inputBehaviour.ArrowUp && !_animator.GetCurrentAnimatorStateInfo(2).IsName("Up")) //up
        {
            _animator.SetTrigger("Shoot_Up");
            _animator.SetBool("Not_Shooting", false);
        }
                   
        if (_inputBehaviour.ArrowDown == false && _inputBehaviour.ArrowLeft == false && _inputBehaviour.ArrowRight == false && _inputBehaviour.ArrowUp == false)
            _animator.SetBool("Not_Shooting", true);
    
    }
}
