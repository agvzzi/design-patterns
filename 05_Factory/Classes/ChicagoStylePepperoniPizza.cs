namespace _05_Factory.Classes;

public class ChicagoStylePepperoniPizza : Pizza
{
    public override void Prepare()
    {
        Console.WriteLine("Preparing a ChicagoStyle Pepperoni pizza");
    }

    public override void Bake()
    {
        Console.WriteLine("Baking a ChicagoStyle Pepperoni pizza");
    }

    public override void Cut()
    {
        Console.WriteLine("Cuting a ChicagoStyle Pepperoni pizza");
    }

    public override void Box()
    {
        Console.WriteLine("Boxing a ChicagoStyle Pepperoni pizza");
    }
}