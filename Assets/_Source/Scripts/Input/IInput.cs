using UnityEngine;

public interface IInput
{
    IKey Drag { get; }
    IKey Spawn { get; }
    IKey SwichItem { get; }
    IKey SwichCamera { get; }
    Vector2 MousePosition { get; }
}
