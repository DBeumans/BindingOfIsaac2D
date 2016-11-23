using UnityEngine;
using System.Collections;

public class Bullet_Destroy : MonoBehaviour {
    
    public void DestroyBullet()
    {
        Destroy(this.gameObject);
    }
}
