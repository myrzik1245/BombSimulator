using System;
using UnityEngine;

[Serializable]
public class PrefabItem : ISpawnItem
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private Vector3 _offset;

    public void Execute(Vector3 spawnPosition)
    {
        spawnPosition = spawnPosition += _offset;
        GameObject.Instantiate(_prefab, spawnPosition, Quaternion.identity);
    }
}
