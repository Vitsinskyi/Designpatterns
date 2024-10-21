namespace Memento;

public class TextDocument
{
    private string _state;
    private string _text;

    public TextDocument(string initialState, string initialText)
    {
        _state = initialState;
        _text = initialText;
        Console.WriteLine($"Initial state is: {_state}, text: {_text}");
    }

    public void UpdateContent()
    {
        Console.WriteLine("Updating some text here.");
        _state = "Lorem Lorem";
        _text = "Lorem Ipsum is simply dummy text :)";
        Console.WriteLine($"State has changed to: {_state}, text: {_text}");
    }

    public IMemento SaveChanges()
    {
        return new Memento(_state, _text, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
    }

    public void UndoChanges(IMemento memento)
    {
        if (memento is Memento)
        {
            _state = memento.GetState();
            _text = memento.GetText();
            Console.WriteLine($"State and text have been restored to: {_state}, {_text}");
        }
        else
        {
            throw new ArgumentException("unexpected error");
        }
    }
}