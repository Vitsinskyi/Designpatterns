namespace Composite;

public class VisibleState : IVisibilityState
{
    public void Apply(LightElementNode node)
    {
        node.RemoveClass("hidden");
    }
}