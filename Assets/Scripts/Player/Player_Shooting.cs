using UnityEngine;
using System.Collections;

public class Player_Shooting : MonoBehaviour {

    InputBehaviour _inputBehaviour;

    [SerializeField]GameObject _bulletPrefab;
    [SerializeField]Transform _player_muzzle;

    private float fireRate = 0.1f;
    public float nextFire = 0.0f;

    public void CreateBullet()
    {
        nextFire = Time.time + fireRate;
        Player_Bullet newProjectile = Instantiate(_bulletPrefab, _player_muzzle.position, _player_muzzle.rotation) as Player_Bullet;
    }
}
