using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

    [SerializeField]GameObject[] _objects;
    [SerializeField]Transform[] _spawnPoints;

    GameObject _object;
    Transform _spawnPoint;

    void Start()
    {
        ObjectSpawner();
    }

    public void ObjectSpawner()
    {
        for (int j = 0; j < _spawnPoints.Length; j++)
        {
            _spawnPoint = _spawnPoints[j];
            _object = _objects[0];
            if (_spawnPoint == _spawnPoints[3])
            {
                _object = _objects[1];
            }
            Instantiate(_object, _spawnPoint.position, _spawnPoint.rotation);
        }
    }

}
