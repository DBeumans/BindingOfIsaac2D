using UnityEngine;
using System.Collections;

public class FX_Sprite_Movement : MonoBehaviour {

    Rigidbody2D _rigidBody2D;
    SpeedBehaviour _speedBehaviour;

    float x, y;
    [SerializeField]
    float _speed;
    void Start()
    {
        _rigidBody2D = GetComponent<Rigidbody2D>();
        _speedBehaviour = GetComponent<SpeedBehaviour>();

        x = Random.Range(-1, 1);
        y = Random.Range(-1, 1);
    }

    void FixedUpdate()
    {

        if(_speed >0)
        {
            _rigidBody2D.AddForce(new Vector2(x, y) * _speed * Time.deltaTime*2);
            _speed-=.5f;
            _speedBehaviour.Coroutine();
        }     
        if (_speed == 0)
            _speed = 0;
    }

}
