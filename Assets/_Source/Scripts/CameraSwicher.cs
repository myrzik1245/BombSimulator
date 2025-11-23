using Cinemachine;
using UnityEngine;

public class CameraSwicher : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera[] _cameras;

    private IInput _input;
    private IndexSwicher _swicher;

    private CinemachineVirtualCamera CurrentCamera => _cameras[_swicher.Index];

    public void Initialize(IInput input)
    {
        _input = input;
        _swicher = new IndexSwicher(_cameras.Length);
    }

    private void Update()
    {
        if (_input.SwichCamera.Down)
            Swich();
    }

    private void Swich()
    {
        CurrentCamera.Priority = int.MinValue;

        _swicher.SwichNextIndex();

        CurrentCamera.Priority = int.MaxValue;
    }
}
