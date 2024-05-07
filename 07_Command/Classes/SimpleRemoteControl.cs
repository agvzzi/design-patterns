using _07_Command.Interfaces;

namespace _07_Command.Classes;

public class SimpleRemoteControl
{
    ICommand? slot;

    public SimpleRemoteControl() { }

    public void SetCommand(ICommand command)
    {
        slot = command;
    }

    public void ButtonWasPressed()
    {
        slot?.Execute();
    }
}