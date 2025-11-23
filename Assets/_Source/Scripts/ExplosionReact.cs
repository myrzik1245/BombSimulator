using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ExplosionReact : MonoBehaviour
{
    private Rigidbody _rigidbody;

    public void React(Vector3 explosionCenter, float force)
    {
        _rigidbody.isKinematic = false;

        Vector3 direction = (transform.position - explosionCenter).normalized;
        _rigidbody.AddForce(direction * force, ForceMode.Impulse);
    }

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
}
