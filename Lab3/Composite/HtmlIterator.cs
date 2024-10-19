namespace Composite;

public class HtmlIterator : IHtmlIterator
{
    private LightNode _current;
    private IEnumerator<LightNode> _enumerator;
    private Dictionary<Type, int> _typeCounts = new Dictionary<Type, int>();

    public HtmlIterator(IEnumerable<LightNode> nodes)
    {
        _enumerator = nodes.GetEnumerator();
        InitializeTypeCounts(nodes);
    }

    public LightNode GetCurrent()
    {
        return _current;
    }

    public bool MoveNext()
    {
        if (_enumerator.MoveNext())
        {
            _current = _enumerator.Current;
            return true;
        }
        return false;
    }

    public int CountElementsOfType<T>() where T : LightNode
    {
        Type type = typeof(T);
        int count = 0;
        foreach (var node in _typeCounts.Keys)
        {
            if (type.IsAssignableFrom(node))
            {
                count += _typeCounts[node];
            }
        }
        return count;
    }

    private void InitializeTypeCounts(IEnumerable<LightNode> nodes)
    {
        foreach (var node in nodes)
        {
            Type type = node.GetType();
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
}