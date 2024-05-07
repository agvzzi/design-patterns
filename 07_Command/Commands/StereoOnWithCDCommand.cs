using _07_Command.Classes;
using _07_Command.Interfaces;

namespace _07_Command.Commands;

public class StereoOnWithCDCommand : ICommand
{
    private Stereo stereo;

    public StereoOnWithCDCommand(Stereo stereo)
    {
        this.stereo = stereo;
    }

    public void Execute()
    {
        stereo.On();
        stereo.SetCD();
        stereo.SetVolume(11);
    }
}