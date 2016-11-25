using UnityEngine;
using System.Collections;

public class MovementBehaviour : MonoBehaviour {

	Vector2 _position = new Vector2();
	Vector2 _velocity = new Vector2();

	Vector2 _up = Vector2.up;
	Vector2 _left = Vector2.left;
	Vector2 _down = Vector2.down;
	Vector2 _right = Vector2.right;

	private float _speed = 0.3f;

	public void Up() { _velocity = _up; }
	public void UpLeft() { _velocity = _up + _left; }
	public void Left() { _velocity = _left; }
	public void DownLeft() { _velocity = _down + _left;}
	public void Down() { _velocity = _down; }
	public void DownRight() { _velocity = _down + _right; }
	public void Right() { _velocity = _right; }
	public void UpRight() { _velocity = _up + _right; }

	public Vector2 position { 
		get { 
			return _position += _velocity * Time.deltaTime * _speed;
		}
		set {
			_position = value;
		}
	}
}
