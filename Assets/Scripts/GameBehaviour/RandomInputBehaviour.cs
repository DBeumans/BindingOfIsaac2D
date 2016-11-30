using UnityEngine;
using System.Collections;

public class RandomInputBehaviour : MonoBehaviour {
	private Vector2 moveInput = new Vector2();

	public Vector2 MoveInput { get { return moveInput; } }

	public void RandomF() {
		int x = Random.Range(-1,1);
		int y = Random.Range(-1,1);
		moveInput = new Vector2(x, y);
	}
}