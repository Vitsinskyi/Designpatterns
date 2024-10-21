namespace Memento;

public interface IMemento
{
    string GetTime();

    string GetState();

    string GetText();
}