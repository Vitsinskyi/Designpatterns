namespace Composite;

public interface IVisitor
{
    void Visit(LightTextNode node);
    void Visit(LightElementNode node);
}