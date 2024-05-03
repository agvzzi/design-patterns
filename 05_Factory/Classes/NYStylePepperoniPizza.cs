namespace _05_Factory.Classes;

public class NYStylePepperoniPizza : Pizza
{
    public override void Prepare()
    {
        Console.WriteLine("Preparing a NYStyle Pepperoni pizza");
    }

    public override void Bake()
    {
        Console.WriteLine("Baking a NYStyle Pepperoni pizza");
    }

    public override void Cut()
    {
        Console.WriteLine("Cuting a NYStyle Pepperoni pizza");
    }

    public override void Box()
    {
        Console.WriteLine("Boxing a NYStyle Pepperoni pizza");
    }
}