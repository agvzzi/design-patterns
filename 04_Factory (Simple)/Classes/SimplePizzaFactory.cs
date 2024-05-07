namespace _04_Factory.Classes;

public class SimplePizzaFactoy
{
    public Pizza CreatePizza(string type)
    {
        Pizza pizza;

        switch (type)
        {
            case "Cheese":
                pizza = new CheesePizza();
                break;
            case "Pepperoni":
                pizza = new PepperoniPizza();
                break;
            case "Clam":
                pizza = new ClamPizza();
                break;
            case "Veggie":
                pizza = new VeggiePizza();
                break;
            default:
                throw new NotImplementedException();
        }

        return pizza;
    }
}