using UnityEngine;
using System.Collections;

public class Player_Movement_Animation : MonoBehaviour {

    Animator _animator;
    InputBehaviour _inputBehaviour;

    float _vertical;
    float _horizontal;

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

        if(Mathf.Abs(_vertical) ==0 && Mathf.Abs(_horizontal ) == 0)
        {
            _animator.SetBool("PlayerMoving", false);
        }
    }
}
