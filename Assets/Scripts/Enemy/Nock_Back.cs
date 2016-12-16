using UnityEngine;
using System.Collections;

public class Nock_Back : MonoBehaviour {
	private Rigidbody2D _rigidbody2D;
	private SpeedBehaviour _slowMovement;

	[SerializeField]private Get_Trigger up;
	[SerializeField]private Get_Trigger left;
	[SerializeField]private Get_Trigger right;
	[SerializeField]private Get_Trigger down;

	private bool _up;
	private bool _left;
	private bool _right;
	private bool _down;

	private float _speed = 5;

	void Start() {
		_rigidbody2D = GetComponent<Rigidbody2D>();
		_slowMovement = GetComponent<SpeedBehaviour>();
		
	}

	void FixedUpdate() {
		Triggered();

		if (_up) {
			_rigidbody2D.AddForce(-transform.up * _speed);
            _slowMovement.Coroutine();
            _up = false;
		}
		if (_left) {
			_rigidbody2D.AddForce(transform.right * _speed);
            _slowMovement.Coroutine();
            _left = false;
		}
		if (_right) {
			_rigidbody2D.AddForce(-transform.right * _speed);
            _slowMovement.Coroutine();
            _right = false;
		}
		if (_down) {
			_rigidbody2D.AddForce(transform.up * _speed);
            _slowMovement.Coroutine();
            _down = false;
		}

		//_slowMovement.rigidbody2D = _rigidbody2D;
	}

	void Triggered() {
		_up = up.triggered;
		_left = left.triggered;
		_right = right.triggered;
		_down = down.triggered;

		up.triggered = _up;
		left.triggered = _left;
		right.triggered = _right;
		down.triggered = _down;
	}
}
