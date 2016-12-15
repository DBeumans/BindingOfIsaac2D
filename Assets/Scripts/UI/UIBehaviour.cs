using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIBehaviour : MonoBehaviour {

    [SerializeField]
    GameObject _lose_panel;
    [SerializeField]
    GameObject _pauze_panel;

    bool _lose_panel_active = false;

    public bool LosePanelActive { get { return _lose_panel_active; } }

    Player_InputCheck _player_InputCheck;

    Player_Health _player_Health;

    void Start()
    {
        _player_InputCheck = GameObject.FindObjectOfType<Player_InputCheck>();
        _player_Health = GameObject.FindObjectOfType<Player_Health>();

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
        if (_player_InputCheck.IsPauzed)
            _pauze_panel.SetActive(true);
        if (!_player_InputCheck.IsPauzed)
            _pauze_panel.SetActive(false);
    }

    void Lost()
    {
        _pauze_panel.SetActive(false);
        _lose_panel.SetActive(true);
        _lose_panel_active = true;
             
    }
}
