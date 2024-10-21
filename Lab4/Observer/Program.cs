namespace Observer;

internal class Program
{
    public static void Main(string[] args)
    {
        LightElementNode div = new LightElementNode("div", true, false);
        div.AddClass("container");
        div.AddChild(new LightTextNode("Hello, World!"));

        LightElementNode span = new LightElementNode("span", false, false);
        span.AddChild(new LightTextNode("This is a span."));
        div.AddChild(span);

        div.AddEventListener("click", () => Console.WriteLine("Div clicked!"));

        div.TriggerEvent("click");

        Console.WriteLine(div.OuterHtml);
        
        //Strategy pattern usage example
        
        var image = new Image(new FileSystemImageLoadingStrategy());

        image.Load("image.jpg");

        image.SetLoadingStrategy(new NetworkImageLoadingStrategy());

        image.Load("https://example.com/image.jpg");
    }
}