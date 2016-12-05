using UnityEngine;
using System.Collections;

public class Enemy_Collision : MonoBehaviour {

    Player_Bullet _player_Bullet;
    Enemy_Health _enemy_Health;

    void Start()
    {
        _player_Bullet = FindObjectOfType<Player_Bullet>();
        _enemy_Health = GetComponent<Enemy_Health>();
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Bullet")
        {
            // if get touched by a bullet
            Debug.Log("Bullet");
            _enemy_Health.GetDamage(_player_Bullet.BulletDamage);
        }
    }
}
