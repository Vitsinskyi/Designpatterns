namespace Composite;

class Program
{
    static void Main(string[] args)
    {
        LightElementNode div = new LightElementNode("div", true, false);
        div.AddClass("container");
        div.AddChild(new LightTextNode("Hello, World!"));

        LightElementNode span1 = new LightElementNode("span", false, false);
        span1.AddChild(new LightTextNode("This is a span."));
        div.AddChild(span1);
        
        LightElementNode span2 = new LightElementNode("span", false, false);
        span2.AddChild(new LightTextNode("This is a second span."));
        div.AddChild(span2);
        span2.SetVisibilityState(new HiddenState());
        
        ICommand addClassCommand = new AddClassCommand("highlight");
        div.ExecuteCommand(addClassCommand);
        
        div.Render();
        
        div.UndoCommand(addClassCommand);
        span2.SetVisibilityState(new VisibleState());
        
        div.Render();
        
        var visitor = new ElementCounterVisitor();
        var iterator = div.GetIterator();
        while (iterator.MoveNext())
        {
            var node = iterator.GetCurrent();
            node.Accept(visitor);
        }
        Console.WriteLine($"Number of LightElementNodes: {visitor.ElementNodeCount}");
        Console.WriteLine($"Number of LightTextNodes: {visitor.TextNodeCount}");
        
    }
}