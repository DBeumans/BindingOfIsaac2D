using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Enemy_Blood_Walk_Trace : FX_Spawner {

    int _count;

    void Awake()
    {
        _minOpacity = .5f;
        _maxOpacity = 1f;
    }

    void Blood_Walk_Trace()
    {
        if (_count >= _shown_FX_Gameobject)
        {
            Destroy(_fx_list[0].gameObject); // removes the first 'spawned' gameobject.
            _fx_list.RemoveAt(0);
        }
        Instantiate_FX();
        _count++;
    }
}
