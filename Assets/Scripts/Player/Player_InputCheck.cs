using UnityEngine;
using System.Collections;

public class Player_InputCheck : InputBehaviour {

    //script reference here

    Player_Health _player_Health;

    bool _isPauzed = false;

    public bool IsPauzed { get { return _isPauzed; } }
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
    }
}
