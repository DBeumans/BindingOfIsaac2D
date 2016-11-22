using UnityEngine;
using System.Collections;

public class Player_InputCheck : InputBehaviour {

    //script reference here.

    Player_Shooting _player_Shooting;

    void Start()
    {
        _player_Shooting = GetComponent<Player_Shooting>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        KeyCheck();

        if(ShootKey)
        { _player_Shooting.CreateBullet(); }

    }
}
