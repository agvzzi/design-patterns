namespace _05_Factory.Classes;

public class ClamPizza : Pizza
{
    public override void Prepare()
    {
        Console.WriteLine("Preparing a Clam pizza");
    }

    public override void Bake()
    {
        Console.WriteLine("Baking a Clam pizza");
    }

    public override void Cut()
    {
        Console.WriteLine("Cuting a Clam pizza");
    }

    public override void Box()
    {
        Console.WriteLine("Boxing a Clam pizza");
    }
}