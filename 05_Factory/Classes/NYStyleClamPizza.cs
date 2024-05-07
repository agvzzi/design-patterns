namespace _05_Factory.Classes;

public class NYStyleClamPizza : Pizza
{
    public override void Prepare()
    {
        Console.WriteLine("Preparing a NYStyle Clam pizza");
    }

    public override void Bake()
    {
        Console.WriteLine("Baking a NYStyle Clam pizza");
    }

    public override void Cut()
    {
        Console.WriteLine("Cuting a NYStyle Clam pizza");
    }

    public override void Box()
    {
        Console.WriteLine("Boxing a NYStyle Clam pizza");
    }
}