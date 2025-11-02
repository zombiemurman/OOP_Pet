using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private List<Item> _itemsPrefab;

    [SerializeField] private List<Transform> _spawnPoints;

    private void Start()
    {
        SpawnItems();
    }

    private void SpawnItems()
    {
        for(int i = 0; i < _itemsPrefab.Count; i++)
        {
            Transform spawnPoint = _spawnPoints[i];

            Instantiate(_itemsPrefab[i], spawnPoint.position, Quaternion.identity);
        }
    }
}
