namespace _03_Decorator.Classes;

public class Decaf : Beverage
{   
    public Decaf()
    {
        description = "Decaf Coffee";
    }

    public override double Cost()
    {
        return 1.05;
    }
}