using UnityEngine;

public class Spawner : MonoBehaviour
{
    private ISpawnItem _currenItem;
    private IInput _input;
    private Camera _mainCamera;

    public void Initialize(IInput input)
    {
        _input = input;
        _mainCamera = Camera.main;
    }

    public void SetSpawnItem(ISpawnItem item)
    {
        _currenItem = item;
    }

    private void Update()
    {
        if (CanSpawn())
            Spawn();
    }

    private bool CanSpawn()
    {
        if (_currenItem == null)
            return false;

        if (_input.Spawn.Down == false)
            return false;

        return true;
    }

    private void Spawn()
    {
        Ray ray = _mainCamera.ScreenPointToRay(_input.MousePosition);

        if (Physics.Raycast(ray, out RaycastHit hit))
            _currenItem.Execute(hit.point);
    }
}
