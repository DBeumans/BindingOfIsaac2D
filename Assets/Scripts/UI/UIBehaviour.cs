using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIBehaviour : MonoBehaviour {

    [SerializeField]
    GameObject _lose_panel;
    [SerializeField]
    GameObject _pauze_panel;
    [SerializeField]
    GameObject _win_panel;

    bool _lose_panel_active = false;
    bool _win_panel_active=false;
    public bool LosePanelActive { get { return _lose_panel_active; } }
    public bool WinPanelActive { get { return _win_panel_active; } }

    Player_InputCheck _player_InputCheck;
    EnemyTracker _enemyTracker;
    Player_Health _player_Health;

    Animator _animator;

    void Start()
    {
        _player_InputCheck = GameObject.FindObjectOfType<Player_InputCheck>();
        _player_Health = GameObject.FindObjectOfType<Player_Health>();
        _enemyTracker = GameObject.FindObjectOfType<EnemyTracker>();

        _animator = GetComponent<Animator>();

    }


    void Update()
    {
        // als de pauze bool aan staat laat pauze panel zien, anders niet.
        // als de player dood is laat lose panel zien, andere code voert niet meer uit.
        if (_player_Health.GetShowLoseUI)
        {
            Lost();
            return;
        }
        if ( _enemyTracker.GameCleared)
        {
            Win();
            return;
        }
        if (_player_InputCheck.IsPauzed)
        {
            _pauze_panel.SetActive(true);
            _animator.SetBool("pauze_ui", true);
        }
        if (!_player_InputCheck.IsPauzed)
        {
            _pauze_panel.SetActive(false);
            _animator.SetBool("pauze_ui", false);
        }
    }

    void Lost()
    {
        _pauze_panel.SetActive(false);
        _lose_panel.SetActive(true);
        _animator.SetBool("lose_ui", true);
        _lose_panel_active = true;
             
    }

    public void Win()
    {
        
        _pauze_panel.SetActive(false);
        _lose_panel.SetActive(false);
        _win_panel.SetActive(true);
        _animator.SetBool("win_ui",true);
        _win_panel_active = true;
        Time.timeScale = 0;
    }
}
