using _07_Command.Classes;
using _07_Command.Interfaces;

namespace _07_Command.Classes;

public class TVOffCommand : ICommand
{
    private TV tv;

    public TVOffCommand(TV tv)
    {
        this.tv = tv;
    }

    public void Execute()
    {
        tv.Off();
    }
}