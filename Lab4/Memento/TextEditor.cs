namespace Memento;

class TextEditor
{
    private List<IMemento> _memento = new List<IMemento>();
    private TextDocument _originator;

    public TextEditor(TextDocument originator)
    {
        _originator = originator;
    }

    public void Backup()
    {
        Console.WriteLine("Saving changes");
        _memento.Add(_originator.SaveChanges());
    }

    public void Undo()
    {
        if (_memento.Count == 0)
        {
            Console.WriteLine("Nothing to restore.");
            return;
        }

        var memento = _memento.Last();
        _memento.Remove(memento);

        Console.WriteLine($"Restoring changes: {memento.GetTime()}");

        _originator.UndoChanges(memento);
    }

    public void ShowHistory()
    {
        Console.WriteLine("History of changes:");
        foreach (var memento in _memento)
        {
            Console.WriteLine(memento.ToString());
        }
    }
}
