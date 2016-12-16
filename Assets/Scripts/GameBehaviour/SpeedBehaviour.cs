using UnityEngine;
using System.Collections;

public class SpeedBehaviour : MonoBehaviour {

    private Rigidbody2D _rgb2D;
    private Vector2 _rgbVelocity2D;
    public void Coroutine() {
        StartCoroutine(SlowMovementRB2D());
    }
    
    void Start()
    {
        _rgb2D = GetComponent<Rigidbody2D>();
    }

    public Vector2 rigidbodyVelocity2D { get { return _rgbVelocity2D;} }
    public Rigidbody2D rigidbody2D { get { return _rgb2D; } set { _rgb2D = value;} }

    IEnumerator SlowMovementRB2D() {
        while(true)
        {
            _rgb2D.velocity = _rgb2D.velocity * 0.9f;
            yield return new WaitForSeconds(.025f);
        }
    }
}