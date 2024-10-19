namespace Composite;

public class AddClassCommand : ICommand
{
    private string _class;

    public AddClassCommand(string @class)
    {
        _class = @class;
    }

    public void Execute(LightElementNode node)
    {
        node.AddClass(_class);
    }
    
    public void Undo(LightElementNode node)
    {
        node.RemoveClass(_class);
    }
}