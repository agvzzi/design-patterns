using _07_Command.Classes;
using _07_Command.Interfaces;

namespace _07_Command.Commands;

public class CeilingFanOnCommand : ICommand
{
    CeilingFan ceilingFan;
    int prevSpeed;

    public CeilingFanOnCommand(CeilingFan ceilingFan)
    {
        this.ceilingFan = ceilingFan;
    }

    public void Execute()
    {
        prevSpeed = ceilingFan.GetSpeed();
        switch (prevSpeed)
        {
            case 0:
                ceilingFan.Low();
                break;
            case 1:
                ceilingFan.Medium();
                break;
            case 2:
                ceilingFan.High();
                break;
            case 3:
                ceilingFan.Low();
                break;
        }
    }

    public void Undo()
    {
        switch (prevSpeed)
        {
            case 0:
                ceilingFan.Off();
                break;
            case 1:
                ceilingFan.Low();
                break;
            case 2:
                ceilingFan.Medium();
                break;
            case 3:
                ceilingFan.High();
                break;
        }
    }
}