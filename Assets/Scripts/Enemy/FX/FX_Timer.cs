using UnityEngine;
using System.Collections;

public class FX_Timer : MonoBehaviour {

    int _duration = 10;
    float _opacity = 1f;
    SpriteRenderer _spriteRenderer;

    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        StartCoroutine(Opacity());
    }

    IEnumerator Opacity()
    {
        while (_duration > 0)
        {
            if(_spriteRenderer.color.a >0)
            {
                _duration -= 1 ;
                Debug.Log(_duration);
                _opacity -= .1f;
                _spriteRenderer.color = new Color(255, 255, 255, _opacity);
                // lower object opacity while its visible
            }

            yield return new WaitForSeconds(1f);
        }
        Debug.Log("Puddle destroyed");
        // when opacity ( alpha ) is 0 destroy the object.
        Destroy(this.gameObject);
    }
}
