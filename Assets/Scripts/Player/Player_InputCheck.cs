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

        if(Space)
        { _player_Shooting.CreateBullet(); }

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
