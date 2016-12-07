using UnityEngine;
using System.Collections;

public class Enemy_Movement : MonoBehaviour {

    float _movementSpeed = .5f;
    [SerializeField]Vector2 _moveInput;

    float _horizontal;
    float _vertical;
    bool _isMoving;

    public float HorizontalMovement { get { return _horizontal; } }
    public float VerticalMovement { get { return _vertical; } }
    public bool IsMoving { get { return _isMoving; } }
    
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
        _isMoving = true;
        transform.Translate((_moveInput * _movementSpeed)* Time.deltaTime);
       
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
