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
    }

    void FixedUpdate()
    {
        Animation();
    }

    void Animation()
    {
        _horizontal = _inputBehaviour.Horizontal;
        _vertical = _inputBehaviour.Vertical;
        Debug.Log("Horizontal: " + _horizontal + " Vertical: " + _vertical);

        _animator.SetFloat("WalkVertical", _vertical );
        _animator.SetFloat("WalkHorizontal",Mathf.Abs( _horizontal));

        if (_horizontal > .1f)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        if ( _horizontal <.1f)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        
        else
        {
            _animator.SetBool("Idle", true);
        }
        
        
    }
}
