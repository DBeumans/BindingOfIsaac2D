using UnityEngine;
using System.Collections;

public class Player_InputCheck : InputBehaviour {

    //script reference here

    Player_Health _player_Health;
    UI_InputCheck _ui_InputCheck;
    string _arrowPressed="";

    bool _isPauzed = false;

    public bool IsPauzed { get { return _isPauzed; } }
    void Start()
    {
        _player_Health = GetComponent<Player_Health>();
        _ui_InputCheck = GameObject.FindObjectOfType<UI_InputCheck>();
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
            if(!_isPauzed)
            {
                _isPauzed = true;
                Debug.Log("pauzed");
                Time.timeScale = 0;
            }
            else if(_isPauzed)
            {
                _isPauzed = false;
                Debug.Log("not pauzed");
                Time.timeScale = 1;
            }
            
        }

        if (base.Enter)
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
