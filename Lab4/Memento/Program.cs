namespace Memento;

internal class Program
{
    public static void Main(string[] args)
    {
        var document = new TextDocument("Document created", "Here is some text");
        var textEditor = new TextEditor(document);

        textEditor.Backup();

        document.UpdateContent();
        
        textEditor.Backup();

        textEditor.ShowHistory();

        textEditor.Undo();

        textEditor.ShowHistory();
    }
}