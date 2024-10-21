namespace Memento;

public class Memento : IMemento
{
    private readonly string _state;
    private readonly string _text;
    private readonly string _time;

    public Memento(string state, string text, string time)
    {
        _state = state;
        _text = text;
        _time = time;
    }

    public string GetTime() => _time;

    public string GetState() => _state;

    public string GetText() => _text;

    public override string ToString() => $"time: {_time}, state: {_state}, text: {_text}";
}