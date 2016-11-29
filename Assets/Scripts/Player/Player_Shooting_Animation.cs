using UnityEngine;
using System.Collections;

public class Player_Shooting_Animation : MonoBehaviour {


    Animator _animator;
    InputBehaviour _inputBehaviour;

    float _vertical;
    float _horizontal;
    bool _playerShooting;

    public bool PlayerShooting { set { _playerShooting = value; } }

    void Start()
    {
        _animator = GetComponent<Animator>();
        _inputBehaviour = GameObject.FindObjectOfType<InputBehaviour>();
    }

    void Update()
    {
        _inputBehaviour.KeyCheck();
        PlayAnimation();
        _animator.SetBool("PlayerShooting", _playerShooting);
    }
    void PlayAnimation()
    {
        _horizontal = _inputBehaviour.Horizontal;
        _vertical = _inputBehaviour.Vertical;

        _animator.SetFloat("ShootVertical", _vertical);
        _animator.SetFloat("ShootHorizontal", _horizontal);
    }
}
