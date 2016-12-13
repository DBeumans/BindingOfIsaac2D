using UnityEngine;
using System.Collections;

public class Get_Trigger : MonoBehaviour {
	private bool _triggered = false;

	public bool triggered 
	{ 
		get 
		{ 
			return _triggered;
		}
		set 
		{
			_triggered = value;
		}
	}
		
	void OnTriggerEnter2D(Collider2D col) {
		if(col.gameObject.tag == "Bullet" && !_triggered) {
			_triggered = true;
		}
	}
}
