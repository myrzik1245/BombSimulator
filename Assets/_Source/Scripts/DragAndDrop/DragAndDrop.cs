using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    private IInput _input;
    private DragMover _dragingObject;
    private CameraRayShooter _rayShooter;

    public void Initialize(IInput input)
    {
        _input = input;
        _rayShooter = new CameraRayShooter(Camera.main);
    }

    private void Update()
    {
        if (_input.Drag.Down)
            CarryObject();

        else if (_input.Drag.Up)
            DropObject();

        if (_dragingObject != null)
            ProcessDrag();
    }

    private void CarryObject()
    {
        if (_rayShooter.TryShoot(_input.MousePosition, out RaycastHit hit))
            if (hit.collider.TryGetComponent(out DragMover dragMover))
                _dragingObject = dragMover;
    }

    private void DropObject()
    {
        _dragingObject = null;
    }

    private void ProcessDrag()
    {
        if (_rayShooter.TryShoot(_input.MousePosition, out RaycastHit hit))
            _dragingObject.Move(hit.point);
    }
}
