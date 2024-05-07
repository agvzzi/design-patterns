namespace _07_Command.Classes;

public class CeilingFan
{
    public enum Speed { OFF, LOW, MEDIUM, HIGH };
    string location;
    Speed speed;

    public CeilingFan(string location)
    {
        this.location = location;
        speed = Speed.OFF;
    }

    public void High()
    {
        speed = Speed.HIGH;
        Console.WriteLine("The " + location + " ceiling fan is on high");
    }

    public void Medium()
    {
        speed = Speed.MEDIUM;
        Console.WriteLine("The " + location + " ceiling fan is on medium");
    }

    public void Low()
    {
        speed = Speed.LOW;
        Console.WriteLine("The " + location + " ceiling fan is on low");
    }

    public void Off()
    {
        speed = Speed.OFF;
        Console.WriteLine("The " + location + " ceiling fan is off");
    }

    public int GetSpeed()
    {
        return (int)speed;
    }
}