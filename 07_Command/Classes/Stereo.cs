namespace _07_Command.Classes;

public class Stereo
{
    string location;

    public Stereo(string location)
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

    public void SetCD()
    {
        Console.WriteLine("The " + location + " stereo is set for CD input");
    }

    public void SetDvd()
    {
        Console.WriteLine("The " + location + " stereo is set for DVD input");
    }

    public void SetRadio()
    {
        Console.WriteLine("The " + location + " stereo is set for Radio");
    }

    public void SetVolume(int volume)
    {
        Console.WriteLine("The " + location + " stereo volume set to " + volume);
    }
}