
namespace _03_Decorator.Classes;

public abstract class Beverage()
{
    public string description  = "Unknown beverage";

    public virtual string GetDescription()
    {
        return description;
    }

    public abstract double Cost();
}