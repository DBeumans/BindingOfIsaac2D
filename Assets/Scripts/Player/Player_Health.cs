using UnityEngine;
using System.Collections;

public class Player_Health : MonoBehaviour {

    float _maxHealth;
    float _currentHealth;

    bool _isDead;
    public bool IsDead { get { return _isDead; } }
    void Start()
    {
        _maxHealth = 100f;
        _currentHealth = _maxHealth;

        StartCoroutine(CheckHealth());
    }


    IEnumerator CheckHealth()
    {
        while (_currentHealth > 0)
        {
            // alive
            _isDead = false;
            Debug.Log("Health" + _currentHealth);
            yield return new WaitForSeconds(.5f);
        }
        _isDead = true;
    }

    public void GetDamage(int damage)
    {
        _currentHealth -= damage;
    }

    void Dead()
    {
        // enemy is dead
        //do logic.
        Destroy(this.gameObject);
    }

}
