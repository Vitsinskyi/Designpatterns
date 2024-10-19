namespace Composite;

public abstract class LightNode
{
    public abstract string OuterHtml { get; }
    public abstract string InnerHtml { get; }
    
    public void Render()
    {
        OnCreated();
        Console.WriteLine(OuterHtml);
        OnRendered();
    }

    protected virtual void OnCreated() { }
    protected virtual void OnRendered() { }
    protected virtual void OnStylesApplied() { } 
    public abstract IHtmlIterator GetIterator();
    public abstract void Accept(IVisitor visitor);
}