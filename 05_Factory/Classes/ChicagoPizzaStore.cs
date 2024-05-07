namespace _05_Factory.Classes;

public class ChicagoPizzaStore : PizzaStore
{
    public override Pizza CreatePizza(string type)
    {
        Pizza pizza;

        switch (type)
        {
            case "Cheese":
                pizza = new ChicagoStyleCheesePizza();
                break;
            case "Pepperoni":
                pizza = new ChicagoStylePepperoniPizza();
                break;
            case "Clam":
                pizza = new ChicagoStyleClamPizza();
                break;
            case "Veggie":
                pizza = new ChicagoStyleVeggiePizza();
                break;
            default:
                throw new NotImplementedException();
        }

        return pizza;
    }
}