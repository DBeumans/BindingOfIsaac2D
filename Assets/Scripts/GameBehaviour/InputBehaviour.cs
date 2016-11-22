using UnityEngine;
using System.Collections;

public class InputBehaviour : MonoBehaviour {

    // Keyboard
    private bool jump = false;
    private bool escapeButton = false;

    private float horizontal;
    private float vertical;

    // Use the public bool to read the keystatement

    // Read only
    public bool JumpKey { get { return jump; } }
    public bool EscapeKey { get { return escapeButton; } }
    
    public float Horizontal { get { return horizontal; } }
    public float Vertical { get { return vertical; } }
    // Keyboard
    KeyCode Jump = KeyCode.Space;
    KeyCode EscapeButton = KeyCode.Escape;

    public void KeyCheck()
    {
        // Keyboard
        jump = Input.GetKeyDown(Jump);
        escapeButton = Input.GetKeyDown(EscapeButton);
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }
}
