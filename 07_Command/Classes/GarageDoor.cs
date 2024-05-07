namespace _07_Command.Classes;

public class GarageDoor
{
    public void Up()
    {
        Console.WriteLine("Garage door is Open");
    }

    public void Down()
    {
        Console.WriteLine("Garage door is Closed");
    }

    public void Stop()
    {
        Console.WriteLine("Garage door is Stopped");
    }

    public void LightOn()
    {
        Console.WriteLine("Garage light is On");
    }

    public void LightOff()
    {
        Console.WriteLine("Garage light is Off");
    }
}