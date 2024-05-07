using _07_Command.Interfaces;

namespace _07_Command.Commands;

public class MacroCommand : ICommand
{
    ICommand[] commands;

    public MacroCommand(ICommand[] commands)
    {
        this.commands = commands;
    }

    public void Execute()
    {
        foreach (var command in commands)
        {
            command.Execute();
        }
    }
}