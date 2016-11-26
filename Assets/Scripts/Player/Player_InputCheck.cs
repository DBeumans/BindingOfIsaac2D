using UnityEngine;
using System.Collections;

public class Player_InputCheck : InputBehaviour {

    //script reference here

    Player_Shooting _player_Shooting;
    /*
    currentarrowActive welke key is nu actief, die moet uitgevoerd worden 
        als een andere key pressed is dan word currentarrowactive de ingedrukte key en andere arrowkeys worden false gezet.
        */
    string _arrowPressed="";
    void Awake()
    {
        _player_Shooting = GetComponent<Player_Shooting>();
    }

    // Update is called once per frame
    void Update()
    {
        KeyCheck();

        ArrowsCheck();
        if (base.Escape)
        {
            Debug.Log("pauze");
        }
        /*
        if (base.Horizontal != 999)
        {
            Debug.Log("Horizontal: " + base.Horizontal);
        }
        if (base.Vertical != 999)
        {
            Debug.Log("Vertical: " + base.Vertical);
        }
        */
    }

    void ArrowsCheck()
    {
        if (ArrowDown)
        {
            if (_arrowPressed != "down") { _arrowPressed = "down"; }
            else if (_arrowPressed == "down") { _player_Shooting.CreateBullet("Down"); }
        }

        if (ArrowLeft)
        {
            if (_arrowPressed != "left") { _arrowPressed = "left"; }
            else if(_arrowPressed == "left") { _player_Shooting.CreateBullet("Left"); }
        }

        if (ArrowRight)
        {
            if (_arrowPressed != "right") { _arrowPressed = "right"; }
            else if (_arrowPressed == "right") { _player_Shooting.CreateBullet("Right"); }
        }

        if (ArrowUp)
        {
            if (_arrowPressed != "up") { _arrowPressed = "up"; }
            else if (_arrowPressed == "up") { _player_Shooting.CreateBullet("Up"); }
        }
    }
}
