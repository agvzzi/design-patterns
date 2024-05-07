using _07_Command.Classes;
using _07_Command.Interfaces;

namespace _07_Command.Commands;

public class CeilingFanOffCommand : ICommand
{
    CeilingFan ceilingFan;
    int prevSpeed;

    public CeilingFanOffCommand(CeilingFan ceilingFan)
    {
        this.ceilingFan = ceilingFan;
    }

    public void Execute()
    {
        prevSpeed = ceilingFan.GetSpeed();
        ceilingFan.Off();
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