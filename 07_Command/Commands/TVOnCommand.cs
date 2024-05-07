using _07_Command.Classes;
using _07_Command.Interfaces;

namespace _07_Command.Classes;

public class TVOnCommand : ICommand
{
    private TV tv;

    public TVOnCommand(TV tv)
    {
        this.tv = tv;
    }

    public void Execute()
    {
        tv.On();
    }
}