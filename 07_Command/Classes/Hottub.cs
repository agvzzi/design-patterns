namespace _07_Command.Classes;

public class Hottub
{
    public void Circulate()
    {
        Console.WriteLine("Hot tub is circulating");
    }

    public void JetsOn()
    {
        Console.WriteLine("Hot tub jets are on");
    }

    public void JetsOff()
    {
        Console.WriteLine("Hot tub jets are off");
    }

    public void SetTemperature(int temperature)
    {
        Console.WriteLine($"Hot tub temperature set to {temperature} degrees");
    }
}
