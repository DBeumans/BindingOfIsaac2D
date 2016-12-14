using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class UI_InputCheck : InputBehaviour {

    UI_Screen_Fader _ui_Screen_Fader;
    Player_Health _player_Health;

    bool _isPauzed;

    public bool IsPauzed { get { return _isPauzed; } }

    void Start()
    {
        _ui_Screen_Fader = GameObject.FindObjectOfType<UI_Screen_Fader>();
        _player_Health = GameObject.FindObjectOfType<Player_Health>();
        if (_player_Health == null)
            _player_Health = null;
    }

    void Update()
    {
        KeyCheck();

        if (Application.loadedLevel == 0)
        {
            if (base.Enter)
                _ui_Screen_Fader.ChangeScene();
        }
        if(Application.loadedLevel == 1)
        {
            if (base.Escape)
                _isPauzed = true;
            if(_player_Health.IsDead)
            {
                if (base.Enter)
                    Debug.Log("Next Scene, please");
            }
            
        }

       
    }
}
