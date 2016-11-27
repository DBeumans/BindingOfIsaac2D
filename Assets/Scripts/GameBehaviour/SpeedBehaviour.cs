using UnityEngine;
using System.Collections;

public class SpeedBehaviour : MonoBehaviour {

    //comment if Rigidbody2D is in unneeded objeckt
    private Rigidbody2D _rgb2D;
    private Vector2 _rgbVelocity2D;
    //uncomment if Rigidbody3D is in needed objeckt
    //private Rigidbody3D _rgb3D;
    //private Vector3 _rgbVelocity3D;

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

    public void startCoroutine() {
        StartCoroutine(SlowMovementRB2D());
        //StartCoroutine(SlowMovementRB3D());
    }
    

    //comment if Rigidbody2D is in unneeded objeckt
    public Vector2 rigidbodyVelocity2D { get { return _rgbVelocity2D;} }
    public Rigidbody2D rigidbody2D { set { _rgb2D = value;} }

    //uncomment if Rigidbody3D is in needed objeckt
    /*public Vector3 rigidbodyVelocity3D { get { return _rgbVelocity3D;} }
    public Rigidbody3D rigidbody3D { set { _rgb3D = value;} }*/

    public IEnumerator SlowMovementSB() {
        while(true) 
        {
            if (_speedUp) {
                _speed += _addSpeed;
            } else {
                _speed -= _addSpeed;
            }
            yield return new WaitForSeconds(.025f);
        }
    }

    //comment if Rigidbody2D is in unneeded objeckt
    public IEnumerator SlowMovementRB2D() {
        while(true)
        {
            _rgbVelocity2D = _rgb2D.velocity * 0.9f;
            yield return new WaitForSeconds(.025f);
        }
    }

    //uncomment if Rigidbody3D is in needed objeckt
    /*public IEnumerator SlowMovementRB3D() {
        while(true)
        {
            _rgbVelocity3D = _rgb3D.velocity;
            _rgbVelocity3D = _rgbVelocity3D * 0.9f;
            yield return new WaitForSeconds(.025f);
        }
    }*/
}