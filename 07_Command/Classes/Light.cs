namespace _07_Command.Classes;

public class Light
{
    string location;

    public Light(string location)
    {
        this.location = location;
    }

    public void On()
    {
        Console.WriteLine("The " + location + " light is on");
    }

    public void Off()
    {
        Console.WriteLine("The " + location + " light is off");
    }
}