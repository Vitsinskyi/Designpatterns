namespace Composite;

public interface IHtmlIterator
{
    LightNode GetCurrent();
    bool MoveNext();
    int CountElementsOfType<T>() where T : LightNode;
}