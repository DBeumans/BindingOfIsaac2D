using UnityEngine;
using System.Collections;

public class Player_InputCheck : InputBehaviour {

    //script reference here.

    Player_Shooting _player_Shooting;
    Player_Data _player_Data;

    void Start()
    {
        _player_Shooting = GetComponent<Player_Shooting>();
        _player_Data = GameObject.FindObjectOfType<Player_Data>();
    }

    // Update is called once per frame
    void Update()
    {
        KeyCheck();

        if(ArrowDown)
        {
            _player_Shooting.CreateBullet("Down");
            _player_Data._arrowDown = true;
        }

        if (ArrowLeft)
        {
            _player_Shooting.CreateBullet("Left");
            _player_Data._arrowLeft = true;
        }

        if (ArrowRight)
        {
            _player_Shooting.CreateBullet("Right");
            _player_Data._arrowRight = true;
        }

        if (ArrowUp)
        {
            _player_Shooting.CreateBullet("Up");
            _player_Data._arrowUp = true;
        }


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
        else
        {
            _player_Data._arrowUp = false;
            _player_Data._arrowRight = false;
            _player_Data._arrowLeft = false;
            _player_Data._arrowDown = false;
        }
    }
}
