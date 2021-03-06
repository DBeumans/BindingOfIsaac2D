﻿using UnityEngine;
using System.Collections;

public class InputBehaviour : MonoBehaviour {

    // Keyboard
    private bool keySpace = false;
    private bool keyEscape = false;
    private bool keyEnter = false;
    private bool keyW = false;
    private bool keyA = false;
    private bool keyS = false;
    private bool keyD = false;
    private bool arrowLeft = false;
    private bool arrowRight = false;
    private bool arrowUp = false;
    private bool arrowDown = false;

    private float horizontal;
    private float vertical;

    private Vector2 moveInput = new Vector2();

    // Use the public bool to read the keystatement

    public float Horizontal { get { return horizontal; } }
    public float Vertical { get { return vertical; } }
    public bool Escape { get { return keyEscape; } }
    public bool Space { get { return keySpace; } }
    public bool Enter { get { return keyEnter; } }

    public Vector2 MoveInput { get { return moveInput; } }

    public bool ArrowLeft { get { return arrowLeft; } set { arrowLeft = value; } }
    public bool ArrowRight { get { return arrowRight; } set { arrowRight = value; }  }
    public bool ArrowUp { get { return arrowUp; } set { arrowUp = value; } }
    public bool ArrowDown { get { return arrowDown; } set { arrowDown = value; } }
    
    public bool W { get { return keyW; } }
    public bool A { get { return keyA; } }
    public bool S { get { return keyS; } }
    public bool D { get { return keyD; } }

    // Keyboard
    KeyCode _keySpace = KeyCode.Space;
    KeyCode _keyEscape = KeyCode.Escape;
    KeyCode _keyEnter = KeyCode.Return;

    KeyCode _keyW = KeyCode.W;
    KeyCode _keyA = KeyCode.A;
    KeyCode _keyS = KeyCode.S;
    KeyCode _keyD = KeyCode.D;

    KeyCode _arrowUp = KeyCode.UpArrow;
    KeyCode _arrowDown = KeyCode.DownArrow;
    KeyCode _arrowLeft = KeyCode.LeftArrow;
    KeyCode _arrowRight = KeyCode.RightArrow;

    public void KeyCheck()
    {
        // Keyboard
        keySpace = Input.GetKeyDown(_keySpace);
        keyEscape = Input.GetKeyDown(_keyEscape);
        keyEnter = Input.GetKeyDown(_keyEnter);

        moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        keyW = Input.GetKeyDown(_keyW);
        keyA = Input.GetKeyDown(_keyA);
        keyS = Input.GetKeyDown(_keyS);
        keyD = Input.GetKeyDown(_keyD);

        arrowDown = Input.GetKey(_arrowDown);
        arrowLeft = Input.GetKey(_arrowLeft);
        arrowRight = Input.GetKey(_arrowRight);
        arrowUp = Input.GetKey(_arrowUp);
    }
}
