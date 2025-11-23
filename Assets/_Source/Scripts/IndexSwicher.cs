public class IndexSwicher
{
    private int _length;

    public IndexSwicher(int length)
    {
        _length = length;
    }

    public int Index { get; private set; } = 0;

    public void SwichNextIndex()
    {
        Index++;

        if (Index >= _length)
            Index = 0;
    }
}
