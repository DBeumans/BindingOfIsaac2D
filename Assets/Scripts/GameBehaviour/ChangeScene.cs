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
        if (_screenFader == null)
            return;
        if (_screenFader.GetChangeScene)
            Change_Scene(1);
    }

    public void Change_Scene(int index)
    {
        SceneManager.LoadScene(index);
    }
}
