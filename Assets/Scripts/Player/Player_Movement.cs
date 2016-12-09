using UnityEngine;
using System.Collections;

public class Player_Movement : MonoBehaviour {
    SpeedBehaviour _slowMovement;
    Rigidbody2D _rigidbody2D;
    InputBehaviour _keyInput;
    
    [SerializeField]float _movementSpeed = 5f;
    Vector2 _moveInput;
    
    void Start() {
        _slowMovement = GetComponent<SpeedBehaviour>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _keyInput = GetComponent<InputBehaviour>();
        _slowMovement.Coroutine();
    }

    void FixedUpdate() {
        _keyInput.KeyCheck();
        _moveInput = _keyInput.MoveInput;
        _rigidbody2D.AddForce(_moveInput * _movementSpeed);
        _slowMovement.rigidbody2D = _rigidbody2D;
        //_rigidbody2D.velocity = _slowMovement.rigidbody2D.velocity;
    }
}
