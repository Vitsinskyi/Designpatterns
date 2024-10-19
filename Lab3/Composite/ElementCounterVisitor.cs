namespace Composite;

public class ElementCounterVisitor : IVisitor
{
    private int _textNodeCount;
    private int _elementNodeCount;

    public int TextNodeCount => _textNodeCount;
    public int ElementNodeCount => _elementNodeCount;

    public void Visit(LightTextNode node)
    {
        _textNodeCount++;
    }

    public void Visit(LightElementNode node)
    {
        _elementNodeCount++;
    }
}