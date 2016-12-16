using UnityEngine;
using System.Collections;

public class Enemy_Bodyparts_Fx : FX_Spawner {

    float _value,_minValue, _maxValue;
    [SerializeField]int _count;
    void Awake()
    {
        _minOpacity = 1f;
        _maxOpacity = 1f;
    }
    void Instantiate_Body_Fx()
    {
        for (int i = 0; i < _count; i++)
        {
            Body_Part(_minValue, _maxValue);
        }
    }

    void Body_Part(float value1, float value2)
    {
        _value = Random.Range(value1, value2);
        if(_value >= _value / 2) { Instantiate_FX(); }
    }
}
