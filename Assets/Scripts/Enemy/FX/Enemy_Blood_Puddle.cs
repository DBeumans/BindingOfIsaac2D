using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Enemy_Blood_Puddle : FX_Spawner {

    void Awake()
    {
        _minOpacity = .2f;
        _maxOpacity = 1f;
    }
    void Walk_Blood_Puddle()
    {
        Instantiate_FX();
    }
}
