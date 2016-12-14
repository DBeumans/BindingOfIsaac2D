using UnityEngine;
using System.Collections;

public class Enemy_Health : MonoBehaviour {

    // This script it responsible for maintaining the health of the enemy such as damaging and checking the health;
    int _health;
    bool _isDead;
    bool _getDamageFromBullet;
    public bool IsDead { get { return _isDead; } }
    public bool GetDamageFromBullet { get { return _getDamageFromBullet; }
        set { _getDamageFromBullet = value; } }

    EnemyTracker _enemyTracker;

    void Start()
    {
        _health = 100;
        StartCoroutine(CheckHealth());

        _enemyTracker = GameObject.FindObjectOfType<EnemyTracker>();
        
    }

    IEnumerator CheckHealth()
    {
        while (_health > 0)
        {
            // alive
            yield return new WaitForSeconds(.5f);
        }
        _isDead = true;
    }

    public void GetDamage(int damage)
    {
        _getDamageFromBullet = true;
        _health -= damage;

    }

    void Dead()
    {
        // enemy is dead
        //do logic.
        _enemyTracker.RemoveFromList();
        Destroy(this.gameObject);
    }

}
