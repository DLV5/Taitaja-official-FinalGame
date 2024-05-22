using System.Collections.Generic;
using UnityEngine;

public class CivilizationObjectsSpawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> _spawnList = new List<GameObject>();
    private Queue<GameObject> _spawnQueue = new Queue<GameObject>();
    private void Awake()
    {
        foreach (var obj in _spawnList)
        {
            _spawnQueue.Enqueue(obj);
        }
    }
    public void SpawnNextObject()
    {
        GameObject obj = _spawnQueue.Dequeue();
        if (obj != null)
            obj.SetActive(true);
    }
}
