namespace _05_Factory.Classes;

public class NYPizzaStore : PizzaStore
{
    public override Pizza CreatePizza(string type)
    {
        Pizza pizza;

        switch (type)
        {
            case "Cheese":
                pizza = new NYStyleCheesePizza();
                break;
            case "Pepperoni":
                pizza = new NYStylePepperoniPizza();
                break;
            case "Clam":
                pizza = new NYStyleClamPizza();
                break;
            case "Veggie":
                pizza = new NYStyleVeggiePizza();
                break;
            default:
                throw new NotImplementedException();
        }

        return pizza;
    }
}