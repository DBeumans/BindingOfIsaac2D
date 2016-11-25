using UnityEngine;
using System.Collections;

public class Player_InputCheck : InputBehaviour {

    //script reference here

    Player_Shooting _player_Shooting;

    void Awake()
    {
        _player_Shooting = GetComponent<Player_Shooting>();
    }

    // Update is called once per frame
    void Update()
    {
        KeyCheck();

        if(ArrowDown)
        {
            _player_Shooting.CreateBullet("Down");
        }

        if (ArrowLeft)
        {
            _player_Shooting.CreateBullet("Left");
        }

        if (ArrowRight)
        {
            _player_Shooting.CreateBullet("Right");
        }

        if (ArrowUp)
        {
            _player_Shooting.CreateBullet("Up");
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
    }
}
