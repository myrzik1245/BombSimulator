using UnityEngine;

public class CameraRayShooter
{
    private Camera _camera;

    public CameraRayShooter(Camera camera)
    {
        _camera = camera;
    }

    public bool TryShoot(Vector3 mousePosition, out RaycastHit hit)
    {

        Ray ray = _camera.ScreenPointToRay(mousePosition);

        if (Physics.Raycast(ray, out hit))
            return true;

        return false;
    }
}
