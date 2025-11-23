using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class DragMover : MonoBehaviour
{
    private Rigidbody _rigidBody;

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    public void Move(Vector3 position)
    {
        position.y = transform.position.y;
        _rigidBody.MovePosition(position);
    }
}
