using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class UI_Health : MonoBehaviour {
    Player_Health _playerHealth;

    [SerializeField]List<GameObject> _ui_Health_List = new List<GameObject>();
    [SerializeField]Sprite[] _Health_Sprites;

    void Start()
    {
        _playerHealth = GameObject.FindObjectOfType<Player_Health>();
    }

    void Update()
    {
        CheckUI();
    }

    void CheckUI()
    {
        // third healthbar.
        if (_playerHealth.CurrentHealth >= 3f)
        {
            _ui_Health_List[2].GetComponent<Image>().sprite = _Health_Sprites[0];
        }
        if (_playerHealth.CurrentHealth >= 2.5f && _playerHealth.CurrentHealth < 3f)
        {
            _ui_Health_List[2].GetComponent<Image>().sprite = _Health_Sprites[1];
        }
        if (_playerHealth.CurrentHealth < 2.5f)
        {
            _ui_Health_List[2].GetComponent<Image>().sprite = _Health_Sprites[2];
        }
        // Second healthbar.
        if (_playerHealth.CurrentHealth >= 2f && _playerHealth.CurrentHealth < 2.5f)
        {
            _ui_Health_List[1].GetComponent<Image>().sprite = _Health_Sprites[0];
        }
        if (_playerHealth.CurrentHealth >= 1.5f && _playerHealth.CurrentHealth < 2f)
        {
            _ui_Health_List[1].GetComponent<Image>().sprite = _Health_Sprites[1];
        }
        if (_playerHealth.CurrentHealth < 1.5f)
        {
            _ui_Health_List[1].GetComponent<Image>().sprite = _Health_Sprites[2];
        }

        // First healthbar.
        if (_playerHealth.CurrentHealth >= 1f && _playerHealth.CurrentHealth < 1.5f)
        {
            _ui_Health_List[0].GetComponent<Image>().sprite = _Health_Sprites[0];
        }
        if (_playerHealth.CurrentHealth >= 0.5f && _playerHealth.CurrentHealth < 1f)
        {
            _ui_Health_List[0].GetComponent<Image>().sprite = _Health_Sprites[1];
        }
        if (_playerHealth.CurrentHealth < 0.5f)
        {
            _ui_Health_List[0].GetComponent<Image>().sprite = _Health_Sprites[2];
        }
    }
}
