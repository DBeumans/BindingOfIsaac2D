using UnityEngine;
using System.Collections;

public class InputBehaviour : MonoBehaviour {

    // Keyboard
    private bool keySpace = false;
    private bool keyEscape = false;
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

    // Use the public bool to read the keystatement

    // Read only
    public bool Escape { get { return keyEscape; } }
    public bool Space { get { return keySpace; } }

    public bool ArrowLeft { get { return arrowLeft; } }
    public bool ArrowRight { get { return arrowRight; }  }
    public bool ArrowUp { get { return arrowUp; }  }
    public bool ArrowDown { get { return arrowDown; } }
    
    public bool W { get { return keyW; } }
    public bool A { get { return keyA; } }
    public bool S { get { return keyS; } }
    public bool D { get { return keyD; } }

    // Keyboard
    KeyCode _keySpace = KeyCode.Space;
    KeyCode _keyEscape = KeyCode.Escape;

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
        keySpace = Input.GetKey(_keySpace);
        keyEscape = Input.GetKeyDown(_keyEscape);

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
