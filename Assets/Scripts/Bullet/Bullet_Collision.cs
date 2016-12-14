using UnityEngine;
using System.Collections;

public class Bullet_Collision : MonoBehaviour {

    BulletAnimationBehaviour _bulletAnimationBehaviour;
    Bullet_AudioManager _bullet_AudioManager;
    Enemy_Health _enemy_Health;

    void Start()
    {
        _bulletAnimationBehaviour = GetComponent<BulletAnimationBehaviour>();
        _bullet_AudioManager = GetComponent<Bullet_AudioManager>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(this.gameObject.name != other.gameObject.name)
        {
            if(other.gameObject.tag == "Wall")
            {

                _bullet_AudioManager.Audio("Bullet_Hit_Wall");
                _bulletAnimationBehaviour.Bullet_Destroyed();
            }
            if(other.gameObject.tag == "Ground")
            {

                _bullet_AudioManager.Audio("Bullet_Hit_Ground");
                _bulletAnimationBehaviour.Bullet_Destroyed();
            }

            if (this.gameObject.tag == "Enemy_Bullet")
            {
                if (other.gameObject.CompareTag("Player"))
                {
                    _bullet_AudioManager.Audio("Bullet_Hit_Wall");
                    _bulletAnimationBehaviour.Bullet_Destroyed();
                }
            }

            if(this.gameObject.tag == "Bullet")
            {
                if(other.gameObject.CompareTag("Enemy"))
                {
                    _bullet_AudioManager.Audio("Bullet_Hit_Wall");
                    _bulletAnimationBehaviour.Bullet_Destroyed();
                }
            }

        }
    }
}

