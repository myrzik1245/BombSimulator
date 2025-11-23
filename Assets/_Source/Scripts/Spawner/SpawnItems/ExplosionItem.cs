using System;
using UnityEngine;

[Serializable]
public class ExplosionItem : ISpawnItem
{
    [SerializeField] private ParticleSystem _exposionParticle;
    [SerializeField] private float _range;
    [SerializeField] private LayerMask _mask;
    [SerializeField] private float _force;

    public void Spawn(Vector3 position)
    {
        GameObject.Instantiate(_exposionParticle, position, Quaternion.identity);

        Collider[] coliders = Physics.OverlapSphere(position, _range, _mask);
        
        foreach (Collider colider in coliders)
        {
            if (colider.TryGetComponent(out ExplosionReact explosionReact))
                explosionReact.React(position, _force);
        }
    }
}
