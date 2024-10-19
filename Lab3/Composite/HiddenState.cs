namespace Composite;

public class HiddenState : IVisibilityState
{
    public void Apply(LightElementNode node)
    {
        node.AddClass("hidden");
    }
}