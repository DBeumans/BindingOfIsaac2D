using UnityEngine;
using System.Collections;

public class PlayerInput : InputBehaviour {
    MovementBehaviour movement;

    void Awake() {
        //movement.position = this.transform.position;
        movement = GetComponent<MovementBehaviour>();
    }

    void FixedUpdate() {
        base.KeyCheck();
        if(base.Escape){ Debug.Log("pauze");}
        if(base.Space){  Debug.Log("space");}
        if(base.W)          { movement.Up();}
        if(base.W && base.A){ movement.UpLeft();} 
        if(base.A)          { movement.Left();}
        if(base.S && base.A){ movement.DownLeft();}
        if(base.S)          { movement.Down();}
        if(base.S && base.D){ movement.DownRight();}
        if(base.D)          { movement.Right();}
        if(base.W && base.D){ movement.UpRight();}

        transform.position = movement.position;
    }
}