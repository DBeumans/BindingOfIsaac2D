using UnityEngine;
using System.Collections;

public class Enemy_Health : MonoBehaviour {

    // This script it responsible for maintaining the health of the enemy such as damaging and checking the health;
    int _health;
    bool _isDead;

    public bool IsDead { get { return _isDead; } }

    void Start()
    {
        _health = 100;
        StartCoroutine(CheckHealth());
        
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
        _health -= damage;
        Debug.Log("Enemy_Health:" + _health);
    }

    void Dead()
    {
        // enemy is dead
        //do logic.
        Debug.Log("Enemy Dead");
        Destroy(this.gameObject);
    }

}
