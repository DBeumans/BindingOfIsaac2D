using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

    UI_Screen_Fader _screenFader;

    void Start()
    {
        _screenFader = GameObject.FindObjectOfType<UI_Screen_Fader>();
    }

    void Update()
    {
        if (_screenFader.GetChangeScene)
            Change_Scene(1);
    }

    void Change_Scene(int index)
    {
        SceneManager.LoadScene(index);
    }
}
