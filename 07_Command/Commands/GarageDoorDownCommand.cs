using _07_Command.Classes;
using _07_Command.Interfaces;

namespace _07_Command.Commands;

public class GarageDoorDownCommand : ICommand
{
    private GarageDoor garageDoor;

    public GarageDoorDownCommand(GarageDoor garageDoor)
    {
        this.garageDoor = garageDoor;
    }

    public void Execute()
    {
        garageDoor.Down();
    }
}