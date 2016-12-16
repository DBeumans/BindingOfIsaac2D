using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class EnemyTracker : MonoBehaviour
{
    Spawner _spawner;
    [SerializeField]List<GameObject> _enemies_List = new List<GameObject>();

    bool _gameCleared = false;

    public bool GameCleared { get { return _gameCleared; } }

    void Start()
    {
        _spawner = GameObject.FindObjectOfType<Spawner>();
    }

    public void RemoveFromList()
    {
        if (_enemies_List.Count == 0)
            return;
        _enemies_List.RemoveAt(0);
    }

    void Update()
    {
        _enemies_List = _spawner.Objects_List;

        if(_enemies_List.Count == 0)
        {
            _gameCleared = true;
        }
    }
}