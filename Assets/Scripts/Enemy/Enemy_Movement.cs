using UnityEngine;
using System.Collections;

public class Enemy_Movement : MonoBehaviour {

    Rigidbody2D _rigidbody2d;

    float _movementSpeed = 2f;
    float _movementSwitchTime = 2;
    int rng;

    // left right up down;
    void Start()
    {
        _rigidbody2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
        _movementSwitchTime -= Time.deltaTime;
        if(_movementSwitchTime <= 0)
        {
            rng = Random.Range(0, 6);
            _movementSwitchTime = 2;
        }        
    }

    void EnemyMovement()
    {

    }
}
