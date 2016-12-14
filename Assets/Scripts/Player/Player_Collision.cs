using UnityEngine;
using System.Collections;

public class Player_Collision : MonoBehaviour {

    Player_Health _player_Health;
    Player_Damage_Audio _player_damage_Audio;

    void Start()
    {
        _player_Health = GetComponent<Player_Health>();
        _player_damage_Audio = GetComponent<Player_Damage_Audio>();
    }
    
    void CollisionOff()
    {
        gameObject.layer = LayerMask.NameToLayer("Empty");
    }
    
    void CollisionOn()
    {
        gameObject.layer = LayerMask.NameToLayer("Player");
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag != this.gameObject.tag)
        {
            if(other.gameObject.tag == "Enemy")
            {
                _player_Health.GetDamage(.5f);
                _player_damage_Audio.Play_Hit_Damage();
            }
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Enemy_Bullet")
        {
            _player_Health.GetDamage(.25f);
            _player_damage_Audio.Play_Hit_Damage();
        }
    }
}
