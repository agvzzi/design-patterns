using _07_Command.Classes;
using _07_Command.Interfaces;

namespace _07_Command.Commands;

public class GarageDoorUpCommand : ICommand
{
    private GarageDoor garageDoor;

    public GarageDoorUpCommand(GarageDoor garageDoor)
    {
        this.garageDoor = garageDoor;
    }

    public void Execute()
    {
        garageDoor.Up();
    }
}