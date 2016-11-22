using UnityEngine;
using System.Collections;

public class Player_Bullet : MonoBehaviour {

    [SerializeField]
    float _bulletTravelSpeed = 2;
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.right * _bulletTravelSpeed * Time.deltaTime);
    }
}
