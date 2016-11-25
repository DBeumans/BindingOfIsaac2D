using UnityEngine;
using System.Collections;

public class SpeedBehaviour : MonoBehaviour {

    private float _maxSpeed;
    private float _addSpeed;
	private float _speed;
    private bool _speedUp;

    public float maxSpeed {
        get { return _maxSpeed;}
        set { _maxSpeed = value;}
    }

    public float speed {
        get { return _speed;}
        set {
			if (value <= _maxSpeed) {
				_speed = value;
			} else {
				_speed = _maxSpeed;
			}
		}
	}

    public float addSpeed {
        set {
            if(value < _maxSpeed / 2) {
                _addSpeed = value;
            } else {
                _addSpeed = _maxSpeed / 2;
            }
        }
    }

    public bool speedUp { set { _speedUp = value;} }

    void FixedUpdate() {
        if (_speedUp) {
            _speed += _addSpeed;
        } else {
            _speed -= _addSpeed;
        }
    }
}