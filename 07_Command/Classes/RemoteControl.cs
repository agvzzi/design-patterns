using System;
using System.Text;
using _07_Command.Commands;
using _07_Command.Interfaces;

namespace _07_Command.Classes;

public class RemoteControl
{
    ICommand[] onCommands;
    ICommand[] offCommands;

    public RemoteControl()
    {
        onCommands = new ICommand[7];
        offCommands = new ICommand[7];

        ICommand noCommand = new NoCommand();
        for (int i = 0; i < 7; i++)
        {
            onCommands[i] = noCommand;
            offCommands[i] = noCommand;
        }
    }

    public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
    {
        onCommands[slot] = onCommand;
        offCommands[slot] = offCommand;
    }

    public void OnButtonWasPushed(int slot)
    {
        onCommands[slot].Execute();
    }

    public void OffButtonWasPushed(int slot)
    {
        offCommands[slot].Execute();
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append("\n------ Remote Control ------\n");
        for (int i = 0; i < onCommands.Length; i++)
        {
            stringBuilder.Append("[slot " + i + "] " + onCommands[i].GetType().Name + "    " + offCommands[i].GetType().Name + "\n");
        }
        return stringBuilder.ToString();
    }
}