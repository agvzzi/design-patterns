using _07_Command.Classes;
using _07_Command.Interfaces;

namespace _07_Command.Commands;

public class StereoOffCommand : ICommand
{
    private Stereo stereo;

    public StereoOffCommand(Stereo stereo)
    {
        this.stereo = stereo;
    }

    public void Execute()
    {
        stereo.Off();
    }
}