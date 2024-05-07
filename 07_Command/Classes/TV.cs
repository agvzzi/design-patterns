namespace _07_Command.Classes;

public class TV
{
    string location;

    public TV(string location)
    { 
        this.location = location;
    }
    
    public void On()
    {
        Console.WriteLine("The " + location + " Stereo is on");
    }

    public void Off()
    {
        Console.WriteLine("The " + location + " stereo is off");
    }

    public void SetInputChannel()
    {
        Console.WriteLine("The " + location + " stereo is set for CD input");
    }

    public void SetVolume(int volume)
    {
        Console.WriteLine("The " + location + " stereo volume set to " + volume);
    }
}