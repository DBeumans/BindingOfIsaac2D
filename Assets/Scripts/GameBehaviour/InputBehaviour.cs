using UnityEngine;
using System.Collections;

public class InputBehaviour : MonoBehaviour {

    // Keyboard
    private bool shootbutton = false;
    private bool escapeButton = false;

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
    KeyCode keySpace = KeyCode.Space;
    KeyCode keyEscape = KeyCode.Escape;

    KeyCode keyW = KeyCode.W;
    KeyCode keyA = KeyCode.A;
    KeyCode keyS = KeyCode.S;
    KeyCode keyD = KeyCode.D;

    public void KeyCheck()
    {
        // Keyboard
        shootbutton = Input.GetKeyDown(Shootbutton);
        escapeButton = Input.GetKeyDown(EscapeButton);
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }
}
