namespace _05_Factory.Classes;

public class ChicagoStyleVeggiePizza : Pizza
{
    public override void Prepare()
    {
        Console.WriteLine("Preparing a ChicagoStyle Veggie pizza");
    }

    public override void Bake()
    {
        Console.WriteLine("Baking a ChicagoStyle Veggie pizza");
    }

    public override void Cut()
    {
        Console.WriteLine("Cuting a ChicagoStyle Veggie pizza");
    }

    public override void Box()
    {
        Console.WriteLine("Boxing a ChicagoStyle Veggie pizza");
    }
}