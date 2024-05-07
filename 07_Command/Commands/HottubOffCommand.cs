using _07_Command.Classes;
using _07_Command.Interfaces;

namespace _07_Command.Classes;

public class HottubOffCommand : ICommand
{
    private Hottub hottub;

    public HottubOffCommand(Hottub hottub)
    {
        this.hottub = hottub;
    }

    public void Execute()
    {
        hottub.JetsOff();
    }
}