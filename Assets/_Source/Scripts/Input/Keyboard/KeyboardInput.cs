using UnityEngine;

public class KeyboardInput : IInput
{
    public KeyboardInput()
    {
        Drag = new KeyboardKey(KeyCode.Mouse0);
        Spawn = new KeyboardKey(KeyCode.Mouse1);
        SwichItem = new KeyboardKey(KeyCode.F);
        SwichCamera = new KeyboardKey(KeyCode.Space);
    }

    public IKey Drag { get; private set; }
    public IKey Spawn { get; private set; }
    public IKey SwichItem { get; private set; }
    public IKey SwichCamera { get; private set; }
    public Vector2 MousePosition => Input.mousePosition;
}
