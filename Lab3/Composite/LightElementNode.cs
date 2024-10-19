using System.Collections;

namespace Composite;

public class LightElementNode : LightNode, IEnumerable<LightNode>
{
    private string _tagName;
    private bool _isBlock;
    private bool _isSelfClosing;
    private List<string> _cssClasses;
    private List<LightNode> _children;
    private Dictionary<Type, int> _typeCounts = new Dictionary<Type, int>();
    public IVisibilityState VisibilityState { get; private set; }

    public LightElementNode(string tagName, bool isBlock, bool isSelfClosing)
    {
        this._tagName = tagName;
        this._isBlock = isBlock;
        this._isSelfClosing = isSelfClosing;
        this._cssClasses = new List<string>();
        this._children = new List<LightNode>();
        this.VisibilityState = new VisibleState();
    }

    public void AddClass(string cssClass)
    {
        _cssClasses.Add(cssClass);
    }

    public void RemoveClass(string cssClass)
    {
        _cssClasses.Remove(cssClass);
    }

    public void AddChild(LightNode child)
    {
        _children.Add(child);
    }
    
    public void SetVisibilityState(IVisibilityState state)
    {
        this.VisibilityState = state;
        this.VisibilityState.Apply(this);
    }

    public override string OuterHtml
    {
        get
        {
            string classes = _cssClasses.Any() ? $" class=\"{string.Join(" ", _cssClasses)}\"" : "";
            string startTag = $"<{_tagName}{classes}>";
            string endTag = _isSelfClosing ? "" : $"</{_tagName}>";
            OnStylesApplied();
            return startTag + InnerHtml + endTag;
        }
    }

    public override string InnerHtml
    {
        get
        {
            return string.Join(_isBlock ? "\n" : "", _children.Select(child => child.OuterHtml));
        }
    }
    
    protected override void OnCreated()
    {
        Console.WriteLine($"Element {_tagName} has been created.");
    }

    protected override void OnRendered()
    {
        Console.WriteLine($"Element {_tagName} has been rendered.");
    }
    
    protected override void OnStylesApplied()
    {
        Console.WriteLine($"Styles have been applied to element {_tagName}.");
    }
    
    public override IHtmlIterator GetIterator()
    {
        return new HtmlIterator(_children);
    }
    
    private void InitializeTypeCounts()
    {
        _typeCounts.Clear();
        foreach (var child in _children)
        {
            Type type = child.GetType();
            if (_typeCounts.ContainsKey(type))
            {
                _typeCounts[type]++;
            }
            else
            {
                _typeCounts[type] = 1;
            }
        }
    }
    
    public IEnumerator<LightNode> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    
    public override void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
    
    public void ExecuteCommand(ICommand command)
    {
        command.Execute(this);
    }

    public void UndoCommand(ICommand command)
    {
        command.Undo(this);
    }
}