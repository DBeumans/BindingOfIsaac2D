using UnityEngine;
using System.Collections;

public class Player_Shooting : MonoBehaviour {

    Player_Shooting_Audio _player_Shooting_Audio;
    

    [SerializeField]GameObject _bulletPrefab;
    [SerializeField]Transform _player_muzzle;
    [SerializeField]float fireRate = 0.5f;
    float nextFire = 0.0f;

    void Start()
    {
        _player_Shooting_Audio = GetComponent<Player_Shooting_Audio>();
    }

    public void CreateBullet(string pos)
    {
        nextFire += Time.deltaTime;
        if(nextFire >= fireRate)
        {
            Player_Bullet newProjectile = Instantiate(_bulletPrefab, _player_muzzle.position, _player_muzzle.rotation) as Player_Bullet;
            _player_Shooting_Audio.Audio();
            Player_Bullet bullet = GameObject.FindObjectOfType<Player_Bullet>();
            bullet.Direction = pos;
            nextFire = 0;
            
        }
        
        
    }
}
