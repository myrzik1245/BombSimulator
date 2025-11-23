using UnityEngine;

public class KeyboardKey : IKey
{
    private KeyCode _keyCode;

    public KeyboardKey(KeyCode keyCode)
    {
        _keyCode = keyCode;
    }

    public bool Down => Input.GetKeyDown(_keyCode);
    public bool Up => Input.GetKeyUp(_keyCode);
    public bool Press => Input.GetKey(_keyCode);
}
