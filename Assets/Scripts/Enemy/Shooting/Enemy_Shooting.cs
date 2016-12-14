using UnityEngine;
using System.Collections;

public class Enemy_Shooting : MonoBehaviour {
    [SerializeField]
    float _coolDown = 2;
    [SerializeField]
    float _coolDownTimer;

    Enemy_CreateBullet _enemy_CreateBullet;

    void Start()
    {
        _enemy_CreateBullet = GetComponent<Enemy_CreateBullet>();
    }
    void Update()
    {
        if(_coolDownTimer>0)
        {
            _coolDownTimer -= Time.deltaTime;
        }
        if(_coolDownTimer < 0)
        {
            _coolDownTimer = 0;
        }
    }

    public void Shoot(string pos)
    {
        if(_coolDownTimer == 0)
        {
            _coolDownTimer = _coolDown;
            _enemy_CreateBullet.CreateBullet(pos);
        }
    }
}
