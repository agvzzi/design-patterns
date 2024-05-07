namespace _05_Factory.Classes;

public class NYStyleVeggiePizza : Pizza
{
    public override void Prepare()
    {
        Console.WriteLine("Preparing a NYStyle Veggie pizza");
    }

    public override void Bake()
    {
        Console.WriteLine("Baking a NYStyle Veggie pizza");
    }

    public override void Cut()
    {
        Console.WriteLine("Cuting a NYStyle Veggie pizza");
    }

    public override void Box()
    {
        Console.WriteLine("Boxing a NYStyle Veggie pizza");
    }
}