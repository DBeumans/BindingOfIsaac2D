using UnityEngine;
using System.Collections;

public class Enemy_Collision : MonoBehaviour
{

    Player_Bullet _player_Bullet;
    Enemy_Health _enemy_Health;
    Enemy_Movement _enemy_Movement;

    void Start()
    {
        _player_Bullet = FindObjectOfType<Player_Bullet>();
        _enemy_Health = gameObject.GetComponentInParent<Enemy_Health>();
        _enemy_Movement = gameObject.GetComponentInParent<Enemy_Movement>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bullet")
        {

            if (this.gameObject.name == "Left")
            {
                //if bullet touched left side of the enemy, apply force to it.
                _enemy_Movement.AddForce("Left");
                _enemy_Health.GetDamage(_player_Bullet.BulletDamage);
            }
            if (this.gameObject.name == "Right")
            {
                _enemy_Movement.AddForce("Right");
                _enemy_Health.GetDamage(_player_Bullet.BulletDamage);
            }
            if (this.gameObject.name == "Up")
            {
                _enemy_Movement.AddForce("Up");
                _enemy_Health.GetDamage(_player_Bullet.BulletDamage);
            }
            if (this.gameObject.name == "Down")
            {
                _enemy_Movement.AddForce("Down");
                _enemy_Health.GetDamage(_player_Bullet.BulletDamage);
            }

            // if get touched by a bullet
            //Debug.Log("Bullet");

        }
    }
}