using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class UI_InputCheck : InputBehaviour {

    UI_Screen_Fader _ui_Screen_Fader;
    Player_Health _player_Health;
    UI_ButtonSound _ui_ButtonSound;
    EnemyTracker _enemyTracker;
    ChangeScene _changeScreen;
    Scene  _currentScene;   

    void Start()
    {
        _ui_Screen_Fader = GameObject.FindObjectOfType<UI_Screen_Fader>();
        _player_Health = GameObject.FindObjectOfType<Player_Health>();
        _changeScreen = GameObject.FindObjectOfType<ChangeScene>();
        _ui_ButtonSound = GameObject.FindObjectOfType<UI_ButtonSound>();
        _enemyTracker = GameObject.FindObjectOfType<EnemyTracker>();
        if (_enemyTracker == null)
            _enemyTracker = null;
        if (_player_Health == null)
            _player_Health = null;
    }

    void Update()
    {
        KeyCheck();
        _currentScene = SceneManager.GetActiveScene();
        if (_currentScene.name == "Main_menu")
        {
            if (base.Space)
            {
                _ui_ButtonSound.PlayButtonSound();
                _ui_Screen_Fader.ChangeScene();
            }
                
        }
        if(_currentScene.name ==  "Game_Scene")
        {
            if(_player_Health.IsDead)
            {
                if (base.Space)
                    _changeScreen.Change_Scene(1);
                if (base.Escape)
                    _changeScreen.Change_Scene(0);
            } 
            if(_enemyTracker.GameCleared)
            {
                if(base.Space)
                {
                    _changeScreen.Change_Scene(0);
                }
            }
        }
       
    }
}
