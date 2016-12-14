using UnityEngine;
using System.Collections;

public class UI_InputCheck : InputBehaviour {

    UI_Screen_Fader _ui_Screen_Fader;

    void Start()
    {
        _ui_Screen_Fader = GameObject.FindObjectOfType<UI_Screen_Fader>();
    }

    void Update()
    {
        KeyCheck();

        if (base.Enter)
            _ui_Screen_Fader.ChangeScene();
    }
}
