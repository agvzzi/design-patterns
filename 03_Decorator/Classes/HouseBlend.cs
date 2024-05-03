namespace _03_Decorator.Classes;

public class HouseBlend : Beverage
{   
    public HouseBlend()
    {
        description = "House Blend Coffee";
    }

    public override double Cost()
    {
        return .89;
    }
}