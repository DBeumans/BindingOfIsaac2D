using UnityEngine;
using System.Collections;

public class Enemy_CreateBullet : MonoBehaviour {

    [SerializeField]GameObject _bulletPrefab;
    [SerializeField]Transform _enemy_muzzle;

    public void CreateBullet(string pos)
    {
        GameObject newProjectile = (GameObject)Instantiate(_bulletPrefab, _enemy_muzzle.position, _enemy_muzzle.rotation) as GameObject;
        //_player_Shooting_Audio.Audio();
        newProjectile.GetComponent<Enemy_Bullet>().Direction = pos;
        /*
        Enemy_Bullet bullet = GameObject.FindObjectOfType<Enemy_Bullet>();
        bullet.Direction = pos;
        */
    }
}
