using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    private IInput _input;
    private DragMover _dragingObject;
    private Camera _mainCamera;

    public void Initialize(IInput input)
    {
        _input = input;
        _mainCamera = Camera.main;
    }

    private void Update()
    {
        if (_input.Drag.Down)
            ShootRay();

        else if (_input.Drag.Up)
            _dragingObject = null;

        if (_dragingObject != null)
            ProcessDrag();
    }

    private void ShootRay()
    {
        Ray ray = _mainCamera.ScreenPointToRay(_input.MousePosition);

        if (Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity))
            if (hit.collider.TryGetComponent(out DragMover dragMover))
                _dragingObject = dragMover;
    }

    private void ProcessDrag()
    {
        Vector3 screenPosition = _input.MousePosition;
        screenPosition.z = _mainCamera.transform.position.y;

        Vector3 worldPosition = _mainCamera.ScreenToWorldPoint(screenPosition);

        _dragingObject.Move(worldPosition);
    }
}
