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

        for (int j = 0; j < _spawnPoints.Length; j++)
        {
            _points = _spawnPoints[j];
            _enemy = _enemies[Random.Range(0, _enemies.Length)];
            if(_points == _spawnPoints[5])
            {
                _enemy = _enemies[1];
            }
            ObjectSpawner(_enemy, _points);
        }
        
    }
}
