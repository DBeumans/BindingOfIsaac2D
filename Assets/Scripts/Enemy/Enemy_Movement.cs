using UnityEngine;
using System.Collections;

public class Enemy_Movement : MonoBehaviour {

    float _movementSpeed = .5f;
    [SerializeField]Vector2 _moveInput;

    float _horizontal;
    float _vertical;

    Animator _animator;

    float _directionTime;
    
    void Start()
    {
        _animator = GetComponent<Animator>();
        StartCoroutine(RandomVector2());
    }

    void FixedUpdate() { Movement(); }

    void Movement()
    {
        transform.Translate((_moveInput * _movementSpeed)* Time.deltaTime);

        _animator.SetFloat("Vertical", _vertical);
        _animator.SetFloat("Horizontal", _horizontal);

        _animator.SetBool("IsMoving", true);

       
        if(Mathf.Abs( _horizontal) < 0 && Mathf.Abs(_vertical) < 0)
        {
            transform.localScale = new Vector2(-2, 2);
        }

    }

    IEnumerator RandomVector2()
    {
        while(true)
        {
            float x = Random.Range(-1f, 1f);
            float y = Random.Range(-1f, 1f);
            _moveInput = new Vector2(x, y);
            _horizontal = x;
            _vertical = y;
            yield return new WaitForSeconds(1f);
        }
    }
}
