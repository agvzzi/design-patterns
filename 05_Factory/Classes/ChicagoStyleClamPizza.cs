namespace _05_Factory.Classes;

public class ChicagoStyleClamPizza : Pizza
{
    public override void Prepare()
    {
        Console.WriteLine("Preparing a ChicagoStyle Clam pizza");
    }

    public override void Bake()
    {
        Console.WriteLine("Baking a ChicagoStyle Clam pizza");
    }

    public override void Cut()
    {
        Console.WriteLine("Cuting a ChicagoStyle Clam pizza");
    }

    public override void Box()
    {
        Console.WriteLine("Boxing a ChicagoStyle Clam pizza");
    }
}