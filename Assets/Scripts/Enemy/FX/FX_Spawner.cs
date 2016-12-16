using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FX_Spawner : MonoBehaviour {

    /*
    misschien kunnen de mogelijkheid hebben om de bloed donkerder te laten spawnen.
    */

    [SerializeField]
    protected GameObject[] _fx_sprite;
    protected float _opacity;
    [SerializeField]protected string _fx_name;
    [SerializeField]protected float _minOpacity;
    [SerializeField]protected float _maxOpacity;

    [Tooltip("howmany fx can there be spawned per object. Keep in mind that this is not a global total amount, this depends PER object, so if you set this to 100 and you have 20 objects ( with this script on it ) the total amount will be 100*20 = 2000 (max_allowed_fx*amount of objects")]
    [SerializeField]protected int _shown_FX_Gameobject;

    [SerializeField]protected List<GameObject> _fx_list = new List<GameObject>();
    
    Transform _position;
    void Start()
    {
        _opacity = Random.Range(_minOpacity, _maxOpacity);
    }
    protected void Instantiate_FX()
    {
        if (_fx_name == "") // the fx must have a name!
            return;
       // if (_fx_list.Count >= _shown_FX_Gameobject)
         //   return;
        _position = this.gameObject.transform;
        int randomFX = Random.Range(0, _fx_sprite.Length);
        GameObject fx = (GameObject)Instantiate(_fx_sprite[randomFX]) as GameObject;
        fx.transform.position = _position.position;      
        fx.gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, _opacity);
        fx.gameObject.name = _fx_name;
        _fx_list.Add(fx);
    }
}
