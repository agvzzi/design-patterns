namespace _07_Command.Interfaces;

public interface ICommand
{
    void Execute();
    virtual void Undo() {}
}