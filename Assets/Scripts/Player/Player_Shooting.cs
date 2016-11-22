using UnityEngine;
using System.Collections;

public class Player_Shooting : MonoBehaviour {

    [SerializeField]GameObject _bulletPrefab;
    [SerializeField]Transform _player_muzzle;

    [SerializeField]float fireRate = 0.5f;
    float nextFire = 0.0f;

    public void CreateBullet()
    {
        nextFire += Time.deltaTime;
        if(nextFire >= fireRate)
        {
            Player_Bullet newProjectile = Instantiate(_bulletPrefab, _player_muzzle.position, _player_muzzle.rotation) as Player_Bullet;

            nextFire = 0;
        }
       
    }
}
