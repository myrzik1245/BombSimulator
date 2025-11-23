using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private DragAndDrop _dragAndDropMover;
    [SerializeField] private Spawner _spawner;
    [SerializeField] private SpawnerItemSwicher _spawnItemSwicher;

    private IInput _input = new KeyboardInput();

    private void Start()
    {
        _dragAndDropMover.Initialize(_input);
        _spawner.Initialize(_input);
        _spawnItemSwicher.Initialize(_input);
    }
}
