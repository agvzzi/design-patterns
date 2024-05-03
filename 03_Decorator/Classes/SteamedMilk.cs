namespace _03_Decorator.Classes;

public class SteamedMilk(Beverage beverage) : CondimentDecorator
{
    private Beverage beverage = beverage;

    public override string GetDescription()
    {
        return beverage.GetDescription() + ", Steamed Milk";
    }

    public override double Cost()
    {
        return .10 + beverage.Cost();
    }
}