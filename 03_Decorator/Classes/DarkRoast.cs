namespace _03_Decorator.Classes;

public class DarkRoast : Beverage
{   
    public DarkRoast()
    {
        description = "Dark Roast Coffee";
    }

    public override double Cost()
    {
        return .99;
    }
}