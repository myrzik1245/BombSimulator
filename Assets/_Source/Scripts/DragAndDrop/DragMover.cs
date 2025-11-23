using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class DragMover : MonoBehaviour
{
    private Rigidbody _rigidBody;

    public void Move(Vector3 position)
    {
        position.y = transform.position.y;
        _rigidBody.MovePosition(position);
    }

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }
}
