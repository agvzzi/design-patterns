namespace _04_Factory.Classes;

public class PepperoniPizza : Pizza
{
    public override void Prepare()
    {
        Console.WriteLine("Preparing a Pepperoni pizza");
    }

    public override void Bake()
    {
        Console.WriteLine("Baking a Pepperoni pizza");
    }

    public override void Cut()
    {
        Console.WriteLine("Cuting a Pepperoni pizza");
    }

    public override void Box()
    {
        Console.WriteLine("Boxing a Pepperoni pizza");
    }
}