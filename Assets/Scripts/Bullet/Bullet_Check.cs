using UnityEngine;
using System.Collections;

public class Bullet_Check : MonoBehaviour {

    BulletAnimationBehaviour _bulletAnimationBehaviour;
    Bullet_Destroy _bullet_Destroy;



    void Start()
    {
        _bullet_Destroy = GetComponent<Bullet_Destroy>();
        _bulletAnimationBehaviour = GetComponent<BulletAnimationBehaviour>();
    }
    
    void Update()
    {
       // Debug.Log(_bulletAnimationBehaviour.AnimationDonePlaying);
        if (_bulletAnimationBehaviour.AnimationDonePlaying)
        {
            _bullet_Destroy.DestroyBullet();
        }
    }


}
