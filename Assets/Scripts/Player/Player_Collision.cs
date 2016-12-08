using UnityEngine;
using System.Collections;

public class Player_Collision : MonoBehaviour {

    Player_Health _player_Health;

    void Start()
    {
        _player_Health = GetComponent<Player_Health>();
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag != this.gameObject.tag)
        {
            if(other.gameObject.tag == "Enemy")
            {
                _player_Health.GetDamage(10);
                Debug.Log("Touched a enemy");
            }
        }
    }
}
