namespace Observer;

public class LightTextNode : LightNode
{
    private string _text;

    public LightTextNode(string text)
    {
        _text = text;
    }

    public override string OuterHtml => _text;
    public override string InnerHtml => _text;
}
