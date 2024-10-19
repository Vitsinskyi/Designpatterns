namespace Composite;

public interface ICommand
{
    void Execute(LightElementNode node);
    void Undo(LightElementNode node);
}