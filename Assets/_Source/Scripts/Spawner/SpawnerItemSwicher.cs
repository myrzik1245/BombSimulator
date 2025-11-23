using UnityEngine;

public class SpawnerItemSwicher : MonoBehaviour
{
    [SerializeField] private Spawner _spawner;
    [SerializeField] private ExplosionItem _explosionItem;
    [SerializeField] private PrefabItem _prefabItem;

    private IInput _input;
    private IndexSwicher _swicher;
    private ISpawnItem[] _spawnItems = new ISpawnItem[2];

    private ISpawnItem CurrentSpawnItem => _spawnItems[_swicher.Index];

    public void Initialize(IInput input)
    {
        _input = input;
        _swicher = new IndexSwicher(_spawnItems.Length);

        _spawnItems[0] = _explosionItem;
        _spawnItems[1] = _prefabItem;

        _spawner.SetSpawnItem(CurrentSpawnItem);


    }
    private void Update()
    {
        if (_input.SwichItem.Down)
        {
            _swicher.SwichNextIndex();
            _spawner.SetSpawnItem(CurrentSpawnItem);
        }
    }
}
