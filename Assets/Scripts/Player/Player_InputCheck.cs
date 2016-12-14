using UnityEngine;
using System.Collections;

public class Player_InputCheck : InputBehaviour {

    //script reference here

    Player_Health _player_Health;
    string _arrowPressed="";
    void Start()
    {
        _player_Health = GetComponent<Player_Health>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_player_Health.IsDead)
            return;

        KeyCheck();
        ArrowsCheck();
        if (base.Escape)
        {
            Debug.Log("pauze");
        }
        if(base.Enter)
        {
            Debug.Log("enter");
        }
    }
    void ArrowsCheck()
    {

        if (ArrowDown)
        {
            if (_arrowPressed != "down") { _arrowPressed = "down";  }

        }

        if (ArrowLeft)
        {
            if (_arrowPressed != "left") { _arrowPressed = "left"; }

        }

        if (ArrowRight)
        {
            if (_arrowPressed != "right") { _arrowPressed = "right"; }

        }

        if (ArrowUp)
        {
            if (_arrowPressed != "up") { _arrowPressed = "up"; }

        }
    }

}
