using UnityEngine;
using System.Collections;

public class Enemy_Movement : MonoBehaviour {

    [SerializeField]float _movementSpeed = .5f;
    [SerializeField]Vector2 _moveInput;

    float _horizontal;
    float _vertical;
    bool _isMoving;

    public float HorizontalMovement { get { return _horizontal; } }
    public float VerticalMovement { get { return _vertical; } }
    public bool IsMoving { get { return _isMoving; } }
    public Vector2 GetMoveInput { get { return _moveInput; } }

    Enemy_Health _enemy_Health;

    float _directionTime;
    
    void Start()
    {
        _enemy_Health = GetComponent<Enemy_Health>();
        StartCoroutine(RandomVector2());
        
    }

    void MoveEnemy()
    {
        _isMoving = true;
    }

    void FixedUpdate() { Movement(); }

    void Movement()
    {
        if(!_enemy_Health.IsDead)
        {
            if (_isMoving)
            {
                transform.Translate((_moveInput * _movementSpeed) * Time.deltaTime);

                if (Mathf.Abs(_horizontal) < 0 && Mathf.Abs(_vertical) < 0)
                {
                    transform.localScale = new Vector2(-2, 2);
                }
            }
        }
        if(_enemy_Health.IsDead)
        {
            _moveInput.x = 0;
            _moveInput.y = 0;
        }
    }

    public void AddForce(string direction)
    {
        switch(direction)
        {
            case "Left":
                Debug.Log("left");
                break;
            case "Right":
                Debug.Log("right");
                break;
            case "Up":
                Debug.Log("up");
                break;
            case "Down":
                Debug.Log("down");
                break;
        }
    }

    IEnumerator RandomVector2()
    {
        while(!_enemy_Health.IsDead)
        {
            float x = Random.Range(-1f, 1f);
            float y = Random.Range(-1f, 1f);
            _moveInput = new Vector2(x, y);
            _horizontal = x;
            _vertical = y;
            yield return new WaitForSeconds(1f);
        }
    }
}
