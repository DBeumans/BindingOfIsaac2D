using UnityEngine;
using System.Collections;

public class Player_Movement : MonoBehaviour {

    float _movementSpeed = 5f;
    Vector2 _velocity;

    Rigidbody2D _rigidbody2D;

    Vector3 _moveInput;

    float _horizontal;
    float _vertical;

    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        StartCoroutine(SlowMovement());
    }

    void FixedUpdate()
    {

        _horizontal = Input.GetAxisRaw("Horizontal");
        _vertical = Input.GetAxisRaw("Vertical");

        _moveInput = new Vector3(_horizontal, _vertical,0f)  ;

        _rigidbody2D.AddForce(_moveInput * _movementSpeed);
        
    }

    IEnumerator SlowMovement()
    {
        while(true)
        {
            _rigidbody2D.velocity = _rigidbody2D.velocity * 0.9f;
            yield return new WaitForSeconds(.025f);
        }

    }
}
