namespace _03_Decorator.Classes;

public class Expresso : Beverage
{   
    public Expresso()
    {
        description = "Espresso";
    }

    public override double Cost()
    {
        return 1.99;
    }
}