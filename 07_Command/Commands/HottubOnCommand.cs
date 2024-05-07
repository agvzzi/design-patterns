using _07_Command.Classes;
using _07_Command.Interfaces;

namespace _07_Command.Classes;

public class HottubOnCommand : ICommand
{
    private Hottub hottub;

    public HottubOnCommand(Hottub hottub)
    {
        this.hottub = hottub;
    }

    public void Execute()
    {
        hottub.Circulate();
        hottub.JetsOn();
        hottub.SetTemperature(40);
    }
}