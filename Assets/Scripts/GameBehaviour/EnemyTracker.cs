using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class EnemyTracker : MonoBehaviour {

    [SerializeField]List<GameObject> _enemiesList = new List<GameObject>();
    GameObject[] _enemiesInScene;
    void Start()
    {
        SetList();
    }

    void SetList()
    {
        _enemiesInScene = GameObject.FindGameObjectsWithTag("Enemy");
        for (int i = 0; i < _enemiesInScene.Length; i++)
        {
            _enemiesList.Add(_enemiesInScene[i]);
        }
    }
}
// W.I.P