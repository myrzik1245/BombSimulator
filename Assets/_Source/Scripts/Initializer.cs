using UnityEngine;

public class Initializer : MonoBehaviour
{
    [SerializeField] private DragAndDrop _dragAndDropMover;
    [SerializeField] private Spawner _spawner;
    [SerializeField] private SpawnerItemSwicher _spawnItemSwicher;
    [SerializeField] private CameraSwicher _cameraSwicher;

    private IInput _input = new KeyboardInput();

    private void Start()
    {
        _cameraSwicher.Initialize(_input);
        _dragAndDropMover.Initialize(_input);
        _spawner.Initialize(_input);
        _spawnItemSwicher.Initialize(_input);
    }
}
