using System;
using UnityEngine;

[Serializable]
public class PrefabItem : ISpawnItem
{
    [SerializeField] private GameObject _prefab;

    public void Execute(Vector3 spawnPosition)
    {
        GameObject.Instantiate(_prefab, spawnPosition, Quaternion.identity);
    }
}
