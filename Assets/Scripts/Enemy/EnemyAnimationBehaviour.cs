using UnityEngine;
using System.Collections;

public class EnemyAnimationBehaviour : MonoBehaviour {

    Animator _animator;
    Enemy_Movement _enemyMovement;
    Enemy_Health _enemyHealth;

    bool _isSpawned;
    bool _showEnemy;

    void Start()
    {
        _animator = GetComponent<Animator>();
        _enemyMovement = GetComponent<Enemy_Movement>();
        _enemyHealth = GetComponent<Enemy_Health>();      
    }

    void Update()
    {
        //_animator.SetBool("IsSpawned", _isSpawned);
        //_animator.SetBool("ShowEnemy", _showEnemy);
            // Movement
            _animator.SetFloat("Vertical", _enemyMovement.VerticalMovement);
            _animator.SetFloat("Horizontal", _enemyMovement.HorizontalMovement);
            _animator.SetBool("IsMoving", _enemyMovement.IsMoving);

            // Death
            _animator.SetBool("IsDead", _enemyHealth.IsDead);
        if (_enemyHealth.GetDamageFromBullet)
        {
            _animator.SetTrigger("GetDamage");
            _enemyHealth.GetDamageFromBullet = false;
        }
    }

    void ShowEnemy()
    {
        _animator.SetTrigger("Show");
    }
}
