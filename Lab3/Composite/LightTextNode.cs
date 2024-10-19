namespace Composite;

public class LightTextNode : LightNode
{
    private string _text;
    private Dictionary<Type, int> _typeCounts = new Dictionary<Type, int>();


    public LightTextNode(string text)
    {
        this._text = text;
    }

    public override string OuterHtml => _text;
    public override string InnerHtml => _text;
    
    protected override void OnCreated()
    {
        Console.WriteLine("Text node has been created.");
    }

    protected override void OnRendered()
    {
        Console.WriteLine("Text node has been rendered.");
    }
    
    public override IHtmlIterator GetIterator()
    {
        return new HtmlIterator(new List<LightNode> { this });
    }
    
    private void InitializeTypeCounts()
    {
        Type type = this.GetType();
        if (_typeCounts.ContainsKey(type))
        {
            _typeCounts[type]++;
        }
        else
        {
            _typeCounts[type] = 1;
        }
    }
    
    public override void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}