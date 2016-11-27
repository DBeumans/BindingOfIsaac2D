using UnityEngine;
using System.Collections;

public class Enemy_Spawner : Spawner {

    [SerializeField]
    GameObject[] _enemies;

    [SerializeField]
    Transform[] _spawnPoints;

    Transform _points;
    GameObject _enemy;

    void Start()
    {
        Spawn();
    }

    void Spawn()
    {
        _enemy = _enemies[1];
        for (int i = 0; i < _spawnPoints.Length; i++)
        {
            _points = _spawnPoints[i];
        }
        ObjectSpawner(_enemy, _points);
        
    }
}
