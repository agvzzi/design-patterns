namespace _03_Decorator.Classes;

public class Whip(Beverage beverage) : CondimentDecorator
{
    private Beverage beverage = beverage;

    public override string GetDescription()
    {
        return beverage.GetDescription() + ", Whip";
    }

    public override double Cost()
    {
        return .10 + beverage.Cost();
    }
}