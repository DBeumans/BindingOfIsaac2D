using UnityEngine;
using System.Collections;

public class Enemy_ColorChanger : MonoBehaviour {

    // if get hit, change color to red
    // then to back to normal color, as in a animation.

    // color reference.
    // when do i want to change color ?
    // ienum to make it look more realistic.

    SpriteRenderer _spriteRenderer;
    Enemy_Health _enemy_Health;

    Color[] _colors;

    float _red;
    float _green;
    float _blue;
    float _alpha;
    /*
    (255,0,0,1) == red;
    () == normal;
    */

    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _enemy_Health = GetComponent<Enemy_Health>();
       // _colors[0] = new Color(255, 0, 0, 1); //red
    }
    void Update()
    {
        SetColor();
    }
    void SetColor()
    {

    }
}
