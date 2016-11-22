using UnityEngine;
using System.Collections;

public class Player_Bullet : MonoBehaviour {

    [SerializeField]
    float _bulletTravelSpeed = 2;
    [SerializeField]string _position;
    public string Position { set { _position = value.ToString() ; } }

    void FixedUpdate() { Movement(); }
    void Movement()
    {
        switch (_position)
        {
            case "Left":
                transform.Translate(Vector3.left * _bulletTravelSpeed * Time.deltaTime);
                break;

            case "Right":
                transform.Translate(Vector3.right * _bulletTravelSpeed * Time.deltaTime);
                break;

            case "Up":
                transform.Translate(Vector3.up * _bulletTravelSpeed * Time.deltaTime);
                break;

            case "Down":
                transform.Translate(Vector3.down * _bulletTravelSpeed * Time.deltaTime);
                break;

            default:
                transform.Translate(Vector3.down * _bulletTravelSpeed * Time.deltaTime);
                break;
        }
    }
}
