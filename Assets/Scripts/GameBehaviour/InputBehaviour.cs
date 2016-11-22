using UnityEngine;
using System.Collections;

public class InputBehaviour : MonoBehaviour
{

    // Keyboard
    private bool shootbutton = false;
    private bool escapeButton = false;

    private float horizontal;
    private float vertical;

    // Use the public bool to read the keystatement

    // Read only
    public bool ShootKey { get { return shootbutton; } }
    public bool EscapeKey { get { return escapeButton; } }
    
    public float Horizontal { get { return horizontal; } }
    public float Vertical { get { return vertical; } }
    // Keyboard
    KeyCode Shootbutton = KeyCode.Space;
    KeyCode EscapeButton = KeyCode.Escape;

    public void KeyCheck()
    {
        // Keyboard
        shootbutton = Input.GetKeyDown(Shootbutton);
        escapeButton = Input.GetKeyDown(EscapeButton);
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }
}
