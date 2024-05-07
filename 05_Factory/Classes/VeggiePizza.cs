namespace _05_Factory.Classes;

public class VeggiePizza : Pizza
{
    public override void Prepare()
    {
        Console.WriteLine("Preparing a Veggie pizza");
    }

    public override void Bake()
    {
        Console.WriteLine("Baking a Veggie pizza");
    }

    public override void Cut()
    {
        Console.WriteLine("Cuting a Veggie pizza");
    }

    public override void Box()
    {
        Console.WriteLine("Boxing a Veggie pizza");
    }
}