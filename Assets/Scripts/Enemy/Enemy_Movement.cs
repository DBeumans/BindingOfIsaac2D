using UnityEngine;
using System.Collections;

public class Enemy_Movement : MonoBehaviour {

    float _movementSpeed = .5f;
    [SerializeField]Vector2 _moveInput;
    
    void Start()
    {
        StartCoroutine(RandomVector2());
    }

    void FixedUpdate() { Movement(); }

    void Movement()
    {
        transform.Translate((_moveInput * _movementSpeed)* Time.deltaTime);
    }

    IEnumerator RandomVector2()
    {
        while(true)
        {
            float x = Random.Range(-1f, 1f);
            float y = Random.Range(-1f, 1f);
            _moveInput = new Vector2(x, y);
            yield return new WaitForSeconds(1f);
        }
    }
}
