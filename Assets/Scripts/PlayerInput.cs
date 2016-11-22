using UnityEngine;
using System.Collections;

public class PlayerInput : InputBehaviour {
    void FixedUpdate() {
        if(base.EscapeKey) {
            Debug.Log("pauze");
        }
        if(base.Horizontal != 999) {
            Debug.Log("Horizontal: " + base.Horizontal);
        }
        if(base.Vertical != 999){
            Debug.Log("Vertical: " + base.Vertical);
        }
    }
}