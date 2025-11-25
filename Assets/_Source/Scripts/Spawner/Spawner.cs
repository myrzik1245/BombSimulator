using UnityEngine;

public class Spawner : MonoBehaviour
{
    private ISpawnItem _currenItem;
    private IInput _input;
    private CameraRayShooter _rayShooter;

    public void Initialize(IInput input)
    {
        _input = input;
        _rayShooter = new CameraRayShooter(Camera.main);
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
        if (_rayShooter.TryShoot(_input.MousePosition, out RaycastHit hit))
            _currenItem.Spawn(hit.point);
    }
}
