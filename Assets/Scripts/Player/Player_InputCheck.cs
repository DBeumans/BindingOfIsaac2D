using UnityEngine;
using System.Collections;

public class Player_InputCheck : InputBehaviour {

    //script reference here

    Player_Shooting _player_Shooting;
    Player_Health _player_Health;
    string _arrowPressed="";
    void Start()
    {
        _player_Shooting = GetComponent<Player_Shooting>();
        _player_Health = GetComponent<Player_Health>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_player_Health.IsDead)
            return;

        KeyCheck();
   //     ArrowsCheck();
        if (base.Escape)
        {
            Debug.Log("pauze");
        }
    }
 /*   void ArrowsCheck()
    {

        if (ArrowDown)
        {
            if (_arrowPressed != "down") { _arrowPressed = "down";  }
            else if (_arrowPressed == "down") {
                _player_Shooting.CreateBullet("Down");
            }
        }

        if (ArrowLeft)
        {
            if (_arrowPressed != "left") { _arrowPressed = "left"; }
            else if(_arrowPressed == "left") {
                _player_Shooting.CreateBullet("Left");
            }
        }

        if (ArrowRight)
        {
            if (_arrowPressed != "right") { _arrowPressed = "right"; }
            else if (_arrowPressed == "right") {
                _player_Shooting.CreateBullet("Right");
            }
        }

        if (ArrowUp)
        {
            if (_arrowPressed != "up") { _arrowPressed = "up"; }
            else if (_arrowPressed == "up") {
                _player_Shooting.CreateBullet("Up");
            }
        }
    }
*/
}
