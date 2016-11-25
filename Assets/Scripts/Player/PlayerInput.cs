using UnityEngine;
using System.Collections;

public class PlayerInput : InputBehaviour {
    MovementBehaviour movement;
    SpeedBehaviour movespeed;

    [SerializeField]
    private float _maxSpeed = 0.3f;

    void Awake() {
        //movement.position = this.transform.position;
        movement = GetComponent<MovementBehaviour>();
        //movespeed = GetComponent<SpeedBehaviour>();
        //movespeed.maxSpeed = _maxSpeed;
        movement.maxSpeed = _maxSpeed;
    }

    void FixedUpdate() {
        base.KeyCheck();
        //movespeed.speedUp = false;

        if(base.Escape){ Debug.Log("pauze");}
        if(base.Space){  Debug.Log("space");}
        if(base.W) { 
            movement.Up(); 
            //movespeed.speedUp = true;
        }
        if(base.W && base.A){ 
            movement.UpLeft(); 
            //movespeed.speedUp = true;
        } 
        if(base.A) { 
            movement.Left(); 
            //movespeed.speedUp = true;
        }
        if(base.S && base.A) { 
            movement.DownLeft(); 
            //movespeed.speedUp = true;
        }
        if(base.S) { 
            movement.Down(); 
            //movespeed.speedUp = true;
        }
        if(base.S && base.D) { 
            movement.DownRight(); 
            //movespeed.speedUp = true;
        }
        if(base.D) { 
            movement.Right(); 
            //movespeed.speedUp = true;
        }
        if(base.W && base.D) { 
            movement.UpRight();
            //movespeed.speedUp = true;
        }

        movement.speed = 0.3f;//movespeed.speed;
        transform.position = movement.position;
    }
}