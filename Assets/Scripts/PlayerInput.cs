using UnityEngine;
using System.Collections;

public class PlayerInput : InputBehaviour {
    void FixedUpdate() {
        if(base.Escape){ Debug.Log("pauze");}
        if(base.Space){  Debug.Log("space");}
        if(base.W){ Debug.Log("W");}
        if(base.A){ Debug.Log("A");}
        if(base.S){ Debug.Log("S");}
        if(base.D){ Debug.Log("D");}
    }
}