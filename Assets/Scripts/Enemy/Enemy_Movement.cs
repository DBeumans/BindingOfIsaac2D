using UnityEngine;
using System.Collections;

public class Enemy_Movement : MonoBehaviour {
    RandomInputBehaviour _randInput;
    SpeedBehaviour _slowMovement;
    Rigidbody2D _rigidbody2D;

    float _movementSwitchTime = 2;
    float _movementSpeed = 2f;
    Vector2 _moveInput;

    void Start() {
        //_randInput = GetComponent<RandomInputBehaviour();
        _slowMovement = GetComponent<SpeedBehaviour>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _slowMovement.Coroutine();
    }

    void FixedUpdate() {
        _movementSwitchTime -= Time.deltaTime;
        if(_movementSwitchTime <= 0) {   
            _randInput.RandomF();
            _movementSwitchTime = 2;
        } 
        
        _moveInput = _randInput.MoveInput;
        _rigidbody2D.AddForce(_moveInput * _movementSpeed);
        _slowMovement.rigidbody2D = _rigidbody2D;
    }
}
