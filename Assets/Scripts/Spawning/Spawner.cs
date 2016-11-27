using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

    public void ObjectSpawner(GameObject gameObject, Transform spawnPoints)
    {
        Instantiate(gameObject, spawnPoints.position, spawnPoints.rotation);
    }

}
