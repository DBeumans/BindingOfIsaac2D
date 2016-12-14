using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_Screen_Fader : MonoBehaviour {
    [SerializeField]
    float _amountTofill = 1f;
    float _fillStep;
    [SerializeField]
    Image _image;

    bool _changeScene = false;
    public bool GetChangeScene { get { return _changeScene; } }

    void Start()
    {
        _image.color = Color.clear;
        // to clear
    }

    public void ChangeScene()
    {
        StartCoroutine(ToBlack());
        
    }
    
    IEnumerator ToBlack()
    {
        _fillStep = _amountTofill;
        while( _image.color.a < 0.95f)
        {
            _image.color = Color.Lerp(_image.color, Color.black, _fillStep * Time.deltaTime);

            yield return null;
        }
        _changeScene = true;
    }


}
