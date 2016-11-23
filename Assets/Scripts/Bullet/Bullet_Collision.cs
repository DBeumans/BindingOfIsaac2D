using UnityEngine;
using System.Collections;

public class Bullet_Collision : MonoBehaviour {

    Bullet_Destroy _bullet_Destroy;

    void Start()
    {
        _bullet_Destroy = GetComponent<Bullet_Destroy>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(this.gameObject.name != other.gameObject.name)
        {
            _bullet_Destroy.DestroyBullet();
            Debug.Log("Destroyed!");
        }
    }
}
