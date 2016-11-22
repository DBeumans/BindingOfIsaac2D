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


    private float horizontal;
    private float vertical;

    // Use the public bool to read the keystatement

    // Read only
    public bool Escape { get { return keyEscape; } }
    public bool Space { get { return keySpace; } }
    
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

    public void KeyCheck()
    {
        // Keyboard
        keySpace = Input.GetKey(_keySpace);
        keyEscape = Input.GetKeyDown(_keyEscape);
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }
}
