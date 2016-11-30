using UnityEngine;
using System.Collections;

public class Player_Collision : MonoBehaviour {

    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag != this.gameObject.tag)
        {
            Debug.Log("dja");
        }
    }
}
