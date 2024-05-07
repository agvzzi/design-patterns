namespace _03_Decorator.Classes;

public class Mocha(Beverage beverage) : CondimentDecorator
{
    private Beverage beverage = beverage;

    public override string GetDescription()
    {
        return beverage.GetDescription() + ", Mocha";
    }

    public override double Cost()
    {
        return .20 + beverage.Cost();
    }
}