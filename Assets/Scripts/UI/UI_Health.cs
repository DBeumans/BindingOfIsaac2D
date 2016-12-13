using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class UI_Health : MonoBehaviour {

    [SerializeField]GameObject _ui_Health;
    float _count;
    Player_Health _playerHealth;

    [SerializeField]List<GameObject> _ui_Health_List = new List<GameObject>();

    Vector2 _position;

    [SerializeField]Sprite[] _Health_Sprites;

    void Start()
    {
        _playerHealth = GameObject.FindObjectOfType<Player_Health>();
        _count = _playerHealth.CurrentHealth;
        SetUI();
        _position = new Vector2(10, 10);
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

    void SetUI()
    {
        for (float i = 0; i < _count; i++)
        {
            GameObject Health_UI = (GameObject)Instantiate(_ui_Health, _ui_Health.transform) as GameObject;
            Health_UI.transform.SetParent(this.transform, false);
            _position.x += 60;
            _position.y = Screen.height - 60;
            Health_UI.transform.position = _position;
            _ui_Health_List.Add(Health_UI);
        }
    }
}
