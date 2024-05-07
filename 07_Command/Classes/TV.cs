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
        Console.WriteLine($"The {location} TV is on");
    }

    public void Off()
    {
        Console.WriteLine($"The {location} TV is off");
    }

    public void SetInputChannel()
    {
        Console.WriteLine($"The {location} TV input channel is changed");
    }

    public void SetVolume(int volume)
    {
        Console.WriteLine($"The {location} TV volume set to {volume}");
    }
}