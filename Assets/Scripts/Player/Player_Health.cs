﻿using UnityEngine;
using System.Collections;

public class Player_Health : MonoBehaviour {

    float _maxHealth;
    float _currentHealth;
    bool _getDamage;
    bool _isDead;
    public bool IsDead { get { return _isDead; } }
    public float CurrentHealth { get { return _currentHealth; } }
    public bool RecieveDamage { get { return _getDamage; } }
    void Awake()
    {
        _maxHealth =3f;
        _currentHealth = _maxHealth;

        StartCoroutine(CheckHealth());
    }


    IEnumerator CheckHealth()
    {
        while (_currentHealth > 0)
        {
            // alive
            _isDead = false;
            yield return new WaitForSeconds(.5f);
        }
        _isDead = true;
    }

    void DamageRecieved()
    {
        _getDamage = false;
    }

    public void GetDamage(float damage)
    {
        _getDamage = true;
        _currentHealth -= damage;
    }

    void Dead()
    {
        // enemy is dead
        //do logic.
        Time.timeScale = 0;
        Destroy(this.gameObject);
    }

}
