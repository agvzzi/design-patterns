namespace _04_Factory.Classes;

public class CheesePizza : Pizza
{
    public override void Prepare()
    {
        Console.WriteLine("Preparing a Cheese pizza");
    }

    public override void Bake()
    {
        Console.WriteLine("Baking a Cheese pizza");
    }

    public override void Cut()
    {
        Console.WriteLine("Cuting a Cheese pizza");
    }

    public override void Box()
    {
        Console.WriteLine("Boxing a Cheese pizza");
    }
}