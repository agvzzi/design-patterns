namespace _03_Decorator.Classes;

public class Soy(Beverage beverage) : CondimentDecorator
{
    private Beverage beverage = beverage;

    public override string GetDescription()
    {
        return beverage.GetDescription() + ", Soy";
    }

    public override double Cost()
    {
        return .15 + beverage.Cost();
    }
}